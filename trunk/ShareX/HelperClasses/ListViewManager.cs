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
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HelpersLib;

namespace ShareX.HelperClasses
{
    public static class ListViewManager
    {
        public static ImageList ListViewControlImages { get; set; }
        public static ImageList DetailViewImageList { get; set; }

        public static void AddThumbnail(MyListView listView, UploadInfo info)
        {
            if (File.Exists(info.FilePath) && Helpers.IsImageFile(info.FilePath))
            {
                if (SettingsManager.ConfigCore.ListViewMode != View.Details)
                {
                    ListViewControlImages.Images.Add(info.FileName, Image.FromFile(info.FilePath));

                    for (int i = 1; i <= ListViewControlImages.Images.Count; i++)
                    {
                        listView.Items[listView.Items.Count - i].ImageIndex = ListViewControlImages.Images.Count - i;
                    }
                }
            }
        }

        internal static void Initialize(MyListView listView)
        {
            if (DetailViewImageList == null)
            {
                DetailViewImageList = new ImageList();
                DetailViewImageList.ColorDepth = ColorDepth.Depth32Bit;
                DetailViewImageList.Images.Add(Properties.Resources.navigation_090_button);
                DetailViewImageList.Images.Add(Properties.Resources.cross_button);
                DetailViewImageList.Images.Add(Properties.Resources.tick_button);
                DetailViewImageList.Images.Add(Properties.Resources.navigation_000_button);
            }

            if (ListViewControlImages == null)
                ListViewControlImages = new ImageList();

            // reset ImageIndex to prevent showing wrong images
            if (listView.View == View.Details)
            {
                listView.LargeImageList = null;
                listView.SmallImageList = DetailViewImageList;
                foreach (ListViewItem lvi in listView.Items)
                {
                    lvi.ImageIndex = 2;
                }

                if (ListViewControlImages != null)
                    ListViewControlImages.Dispose();
            }
            else
            {
                listView.LargeImageList = ListViewControlImages;
                listView.SmallImageList = null;
                listView.LargeImageList.ColorDepth = ColorDepth.Depth32Bit;
                listView.LargeImageList.ImageSize = new System.Drawing.Size(128, 128);

                for (int i = 1; i < ListViewControlImages.Images.Count; i++)
                {
                    listView.Items[listView.Items.Count - i].ImageIndex = ListViewControlImages.Images.Count - i;
                }
            }
        }

        internal static void SetIconError(ListViewItem lvi)
        {
            if (SettingsManager.ConfigCore.ListViewMode == View.Details) lvi.ImageIndex = 1;
        }

        internal static void SetIconCompleted(ListViewItem lvi)
        {
            if (SettingsManager.ConfigCore.ListViewMode == View.Details) lvi.ImageIndex = 2;
        }

        internal static void SetIconUploadStarted(ListViewItem lvi)
        {
            if (SettingsManager.ConfigCore.ListViewMode == View.Details) lvi.ImageIndex = 0;
        }

        internal static void SetIconCreated(ListViewItem lvi)
        {
            if (SettingsManager.ConfigCore.ListViewMode == View.Details) lvi.ImageIndex = 3;
        }
    }
}