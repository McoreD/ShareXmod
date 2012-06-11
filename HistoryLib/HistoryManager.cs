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

using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml;
using HelpersLib;

namespace HistoryLib
{
    public class HistoryManager
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static XMLManager xml;

        public HistoryManager(string historyPath)
        {
            xml = new XMLManager(historyPath);
        }

        public void OpenUI(int maxItemsCount = -1, string title = "History")
        {
            HistoryForm ui = new HistoryForm(this, maxItemsCount, title);
            ui.Show();
        }

        public void Save()
        {
            if (xml != null)
                xml.Save();
        }

        public void SaveAsync()
        {
            ThreadPool.QueueUserWorkItem(state => Save());
        }

        public bool AddHistoryItem(HistoryItem historyItem)
        {
            try
            {
                if (historyItem != null && !string.IsNullOrEmpty(historyItem.Filename) &&
                historyItem.DateTimeUtc != DateTime.MinValue &&
                (!string.IsNullOrEmpty(historyItem.URL) || !string.IsNullOrEmpty(historyItem.Filepath)))
                {
                    log.DebugFormat("Adding {0} to history.", historyItem.Filename);
                    return xml.AddHistoryItem(historyItem);
                }
            }
            catch (Exception e)
            {
                DebugHelper.WriteException(e);
            }

            return false;
        }

        public List<HistoryItem> GetHistoryItems()
        {
            try
            {
                return xml.Load();
            }
            catch (Exception e)
            {
                DebugHelper.WriteException(e);
            }

            return new List<HistoryItem>();
        }

        public bool RemoveHistoryItem(HistoryItem historyItem)
        {
            return xml.RemoveHistoryItem(historyItem);
        }

        public void AddHistoryItemAsync(HistoryItem historyItem)
        {
            WaitCallback thread = state =>
            {
                this.AddHistoryItem(historyItem);
            };

            ThreadPool.QueueUserWorkItem(thread);
        }
    }
}