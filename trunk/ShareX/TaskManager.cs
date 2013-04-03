﻿#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (C) 2012 ShareX Developers

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using HelpersLib;
using HelpersLibMod;
using HistoryLib;
using Microsoft.WindowsAPICodePack.Taskbar;
using ShareX.HelperClasses;
using ShareX.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using UploadersLib;

namespace ShareX
{
    public static class TaskManager
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static List<UploadTask> Tasks;

        public static MyListView ListViewControl { get; set; }

        static TaskManager()
        {
            Tasks = new List<UploadTask>();
        }

        private static void ChangeListViewItemStatus(UploadTask task)
        {
            if (ListViewControl != null)
            {
                ListViewItem lvi = FindListViewItem(task);

                if (lvi != null)
                {
                    lvi.SubItems[1].Text = task.Info.Status;
                }
            }
        }

        private static void CreateListViewItem(UploadTask task)
        {
            if (ListViewControl != null)
            {
                UploadInfo info = task.Info;

                log.InfoFormat("Task in queue. Job: {0}, Type: {1}, Host: {2}", info.Job, info.UploadDestination, info.UploaderHost);

                ListViewItem lvi = new ListViewItem();
                lvi.Tag = task;
                lvi.Text = info.FileName;
                lvi.SubItems.Add("In queue");
                lvi.SubItems.Add(string.Empty);
                lvi.SubItems.Add(string.Empty);
                lvi.SubItems.Add(string.Empty);
                lvi.SubItems.Add(string.Empty);
                lvi.SubItems.Add(info.DataType.ToString());

                var taskImageJobs = Enum.GetValues(typeof(Subtask)).Cast<Subtask>();
                foreach (Subtask job in taskImageJobs)
                {
                    switch (job)
                    {
                        case Subtask.None:
                            continue;
                    }

                    if (info.Subtasks.HasFlag(Subtask.UploadToRemoteHost))
                    {
                        lvi.SubItems.Add(info.UploaderHost);
                        break;
                    }
                    else if (info.Subtasks.HasFlag(job))
                    {
                        lvi.SubItems.Add(job.GetDescription());
                        break;
                    }
                    else
                    {
                        lvi.SubItems.Add(string.Empty);
                        break;
                    }
                }

                lvi.SubItems.Add(string.Empty);
                ListViewControl.Items.Add(lvi);
                lvi.EnsureVisible();
                ListViewControl.FillLastColumn();
            }
        }

        private static ListViewItem FindListViewItem(UploadTask task)
        {
            if (ListViewControl != null)
            {
                foreach (ListViewItem lvi in ListViewControl.Items)
                {
                    UploadTask tag = lvi.Tag as UploadTask;

                    if (tag != null && tag == task)
                    {
                        return lvi;
                    }
                }
            }

            return null;
        }

        public static void Remove(UploadTask task)
        {
            if (task != null)
            {
                task.Stop();
                Tasks.Remove(task);

                ListViewItem lvi = FindListViewItem(task);

                if (lvi != null)
                {
                    ListViewControl.Items.Remove(lvi);
                }

                task.Dispose();
            }
        }

        public static void Start(UploadTask task)
        {
            Tasks.Add(task);
            task.UploadPreparing += new UploadTask.TaskEventHandler(task_UploadPreparing);
            task.UploadStarted += new UploadTask.TaskEventHandler(task_UploadStarted);
            task.UploadProgressChanged += new UploadTask.TaskEventHandler(task_UploadProgressChanged);
            task.UploadCompleted += new UploadTask.TaskEventHandler(task_UploadCompleted);
            CreateListViewItem(task);
            StartTasks();
            TrayIconManager.UpdateTrayIcon();
        }

        private static void StartTasks()
        {
            int workingTasksCount = Tasks.Count(x => x.IsWorking);
            UploadTask[] inQueueTasks = Tasks.Where(x => x.Status == TaskStatus.InQueue).ToArray();

            if (inQueueTasks.Length > 0)
            {
                int len;

                if (SettingsManager.ConfigCore.UploadLimit == 0)
                {
                    len = inQueueTasks.Length;
                }
                else
                {
                    len = (SettingsManager.ConfigCore.UploadLimit - workingTasksCount).Between(0, inQueueTasks.Length);
                }

                for (int i = 0; i < len; i++)
                {
                    inQueueTasks[i].Start();
                }
            }
        }

        public static void StopTasks(int index)
        {
            if (Tasks.Count < index)
            {
                Tasks[index].Stop();
            }
        }

        private static void task_UploadPreparing(UploadTask task)
        {
            log.Info("Preparing task.");
            ChangeListViewItemStatus(task);
            UpdateProgressUI();
            TaskbarHelper.TaskbarSetProgressState(TaskbarProgressBarState.Normal);
        }

        private static void task_UploadStarted(UploadTask task)
        {
            UploadInfo info = task.Info;

            string status = string.Format("Upload started. Filename: {0}", info.FileName);
            if (!string.IsNullOrEmpty(info.FilePath)) status += ", Filepath: " + info.FilePath;
            log.Info(status);

            ListViewItem lvi = FindListViewItem(task);

            if (lvi != null)
            {
                lvi.Text = info.FileName;
                lvi.SubItems[1].Text = info.Status;
            }
        }

        private static void task_UploadProgressChanged(UploadTask task)
        {
            if (ListViewControl != null)
            {
                UploadInfo info = task.Info;

                ListViewItem lvi = FindListViewItem(task);

                if (lvi != null)
                {
                    lvi.SubItems[1].Text = string.Format("{0:0.0}%", info.Progress.Percentage);
                    lvi.SubItems[2].Text = string.Format("{0} / {1}", Helpers.ProperFileSize(info.Progress.Position, "", true), Helpers.ProperFileSize(info.Progress.Length, "", true));

                    if (info.Progress.Speed > 0)
                    {
                        lvi.SubItems[3].Text = Helpers.ProperFileSize((long)info.Progress.Speed, "/s");
                    }

                    lvi.SubItems[4].Text = Helpers.ProperTimeSpan(info.Progress.Elapsed);
                    lvi.SubItems[5].Text = Helpers.ProperTimeSpan(info.Progress.Remaining);
                }

                UpdateProgressUI();
            }
        }

        /// <summary>
        /// Mod 01: Not just uploads, everything gets added to List e.g. Saving to file
        /// </summary>
        /// <param name="info">UploadInfo</param>
        private static void task_UploadCompleted(UploadTask task)
        {
            try
            {
                UploadInfo info = task.Info;

                if (ListViewControl != null && info != null && info.Result != null)
                {
                    info.Result.LocalFilePath = info.FilePath;
                    ListViewItem lvi = FindListViewItem(task);

                    if (string.IsNullOrEmpty(lvi.SubItems[7].Text))
                        lvi.SubItems[7].Text = info.UploaderHost; // update Destination if not empty; this applies for URL Shortening

                    if (info.Result.IsError)
                    {
                        string errors = string.Join("\r\n\r\n", info.Result.Errors.ToArray());

                        log.ErrorFormat("Upload failed. Filename: {0}, Errors:\r\n{1}", info.FileName, errors);

                        lvi.SubItems[1].Text = "Error";
                        lvi.SubItems[8].Text = string.Empty;

                        ListViewManager.set_IconError(lvi);

                        if (SettingsManager.ConfigCore.PlaySoundAfterUpload)
                            SystemSounds.Asterisk.Play();
                    }
                    else
                    {
                        log.InfoFormat("Upload completed. Filename: {0}, URL: {1}, Duration: {2} ms", info.FileName,
                            info.Result.URL, (int)info.UploadDuration.TotalMilliseconds);

                        lvi.SubItems[1].Text = info.Status;
                        ListViewManager.set_IconCompleted(lvi);

                        string url = string.IsNullOrEmpty(info.Result.ShortenedURL) ? info.Result.URL : info.Result.ShortenedURL;
                        string url_or_filepath = string.IsNullOrEmpty(url) ? info.FilePath : url;

                        lvi.SubItems[8].Text = url_or_filepath;

                        if (!string.IsNullOrEmpty(url_or_filepath))
                        {
                            if (SettingsManager.ConfigCore.Outputs.HasFlag(HelpersLibMod.OutputEnum.Clipboard) &&
                                SettingsManager.ConfigCore.Workflow.AfterUploadTasks.HasFlag(AfterUploadTasks.CopyURLToClipboard))
                            {
                                // Save to file only 
                                if (info.Subtasks.HasFlagAny(Subtask.SaveToFile, Subtask.SaveImageToFileWithDialog) &&
                                   !info.Subtasks.HasFlag(Subtask.UploadToRemoteHost) &&
                                   !info.Subtasks.HasFlag(Subtask.CopyImageToClipboard))
                                {
                                    if (!string.IsNullOrEmpty(info.FilePath))
                                        Helpers.CopyTextSafely(info.FilePath);
                                }
                                // Upload to Remote
                                else if (info.Subtasks.HasFlag(Subtask.UploadToRemoteHost))
                                {
                                    if (!string.IsNullOrEmpty(url))
                                        Helpers.CopyTextSafely(url);
                                }
                            }

                        }

                        if ((!info.Result.IsURLExpected || info.Result.IsSuccess) && 
                            !string.IsNullOrEmpty(url_or_filepath))
                        {
                            if (FormsHelper.Main.niTray.Visible && SettingsManager.ConfigCore.ShowBalloonAfterUpload)
                            {
                                FormsHelper.Main.niTray.Tag = url_or_filepath;
                                FormsHelper.Main.niTray.ShowBalloonTip(5000, Application.ProductName + " - completed", url_or_filepath, ToolTipIcon.Info);
                            }

                            if (SettingsManager.ConfigCore.SaveHistory)
                            {
                                HistoryManager.AddHistoryItemAsync(SettingsManager.HistoryFilePath, info.GetHistoryItem());
                            }

                            if (SettingsManager.ConfigCore.ShowClipboardOptionsWizard && info.Job != TaskJob.ShareURL)
                            {
                                WindowAfterUpload dlg = new WindowAfterUpload(info) { Icon = Resources.ShareX };
                                NativeMethods.ShowWindow(dlg.Handle, (int)WindowShowStyle.ShowNoActivate);
                            }
                        }

                        if (SettingsManager.ConfigCore.PlaySoundAfterUpload)
                            SystemSounds.Exclamation.Play();
                    }

                    lvi.EnsureVisible();
                }
            }
            finally
            {
                StartTasks();
                UpdateProgressUI();
            }
        }

        public static void UpdateProgressUI()
        {
            bool isWorkingTasks = false;
            double averageProgress = 0;

            IEnumerable<UploadTask> workingTasks = Tasks.Where(x => x != null && x.IsWorking && x.Info != null);

            if (workingTasks.Count() > 0)
            {
                isWorkingTasks = true;

                workingTasks = workingTasks.Where(x => x.Info.Progress != null);

                if (workingTasks.Count() > 0)
                {
                    averageProgress = workingTasks.Average(x => x.Info.Progress.Percentage);
                }
            }

            string title = Program.Title;
            int averageProgress_int = (int)averageProgress;

            if (isWorkingTasks && averageProgress_int > 0)
            {
                title = string.Format("{1:0.0}% - {0}", Program.Title, averageProgress);
            }
            else
            {
                title = Program.Title;
                TaskbarHelper.TaskbarSetProgressState(TaskbarProgressBarState.NoProgress);
            }

            if (FormsHelper.Main.Text != title)
            {
                TaskbarHelper.TaskbarSetProgressValue(averageProgress_int);
                FormsHelper.Main.Text = title;
            }
        }
    }
}