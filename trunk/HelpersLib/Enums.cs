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
using System.ComponentModel;

namespace HelpersLib
{
    // http://en.wikipedia.org/wiki/List_of_file_formats

    public enum ImageFileExtensions
    {
        [Description("Joint Photographic Experts Group")]
        jpg, jpeg,
        [Description("Portable Network Graphic")]
        png,
        [Description("CompuServe's Graphics Interchange Format")]
        gif,
        [Description("Microsoft Windows Bitmap formatted image")]
        bmp,
        [Description("File format used for icons in Microsoft Windows")]
        ico,
        [Description("Tagged Image File Format")]
        tif, tiff
    }

    public enum TextFileExtensions
    {
        [Description("ASCII or Unicode plaintext")]
        txt, log,
        [Description("ASCII or extended ASCII text file")]
        nfo,
        [Description("C source")]
        c,
        [Description("C++ source")]
        cpp, cc, cxx,
        [Description("C/C++ header file")]
        h,
        [Description("C++ header file")]
        hpp, hxx,
        [Description("C# source")]
        cs,
        [Description("Visual Basic.NET source")]
        vb,
        [Description("HyperText Markup Language")]
        html, htm,
        [Description("eXtensible HyperText Markup Language")]
        xhtml, xht,
        [Description("eXtensible Markup Language")]
        xml,
        [Description("Cascading Style Sheets")]
        css,
        [Description("JavaScript and JScript")]
        js,
        [Description("Hypertext Preprocessor")]
        php,
        [Description("Batch file")]
        bat,
        [Description("Java source")]
        java,
        [Description("Lua")]
        lua,
        [Description("Python source")]
        py,
        [Description("Perl")]
        pl,
        [Description("Visual Studio solution")]
        sln
    }

    public enum EncryptionStrength
    {
        Low = 128, Medium = 192, High = 256
    }

    public enum EDataType
    {
        Default, File, Image, Text, URL
    }

    public enum GIFQuality
    {
        Default, Bit8, Bit4, Grayscale
    }

    public enum EImageFormat
    {
        PNG, JPEG, GIF, BMP, TIFF
    }

    public enum AnimatedImageFormat
    {
        PNG, GIF
    }

    public enum TaskStatus
    {
        InQueue, Preparing, Uploading, URLShortening, Completed, Stopped
    }

    public enum TaskProgress
    {
        ReportStarted, ReportProgress
    }

    public enum WindowButtonAction
    {
        [Description("Minimize to Tray")]
        MinimizeToTray,
        [Description("Minimize to Taskbar")]
        MinimizeToTaskbar,
        [Description("Exit Application")]
        ExitApplication,
        [Description("Do Nothing")]
        Nothing
    }

    public enum ZAppType
    {
        ZScreen, ShareX, JBird
    }

    public enum HotkeyStatus
    {
        Registered, Failed, NotConfigured
    }

    public enum TriangleAngle
    {
        Top, Right, Bottom, Left
    }

    public enum HashType
    {
        MD5, SHA1, SHA256, SHA384, SHA512, RIPEMD160
    }

    public enum TokenType
    {
        Unknown,
        Whitespace,
        Symbol,
        Literal,
        Identifier,
        Numeric,
        Keyword
    }

    [TypeConverter(typeof(EnumToStringUsingDescription))]
    public enum EActivity
    {
        [Description("Capture screen")]
        CaptureScreen,
        [Description("Capture active monitor")]
        CaptureActiveMonitor,
        [Description("Capture active window")]
        CaptureActiveWindow,
        [Description("Capture window or rectangle region")]
        CaptureWindowRectangle,
        [Description("Capture rectangle region")]
        CaptureRectangleRegion,
        [Description("Capture rounded rectangle region")]
        CaptureRoundedRectangleRegion,
        [Description("Capture ellipse region")]
        CaptureEllipseRegion,
        [Description("Capture triangle region")]
        CaptureTriangleRegion,
        [Description("Capture diamond region")]
        CaptureDiamondRegion,
        [Description("Capture polygon region")]
        CapturePolygonRegion,
        [Description("Capture freehand region")]
        CaptureFreeHandRegion,

        [Description("Upload clipboard content")]
        UploadClipboard,
        [Description("Upload file")]
        UploadFile,

        [Description("Copy image to clipboard")]
        ClipboardCopyImage,
        [Description("Annotate image")]
        ImageAnnotate,
        [Description("Save to file")]
        SaveToFile,
        [Description("Save to file with dialog")]
        SaveToFileWithDialog,
        [Description("Perform after capture tasks")]
        AfterCaptureTasks,
        [Description("Upload to remote host")]
        UploadToRemoteHost
    }

    public class EnumToStringUsingDescription : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return (sourceType.Equals(typeof(Enum)));
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return (destinationType.Equals(typeof(String)));
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (!destinationType.Equals(typeof(String)))
            {
                throw new ArgumentException("Can only convert to string.", "destinationType");
            }

            if (!value.GetType().BaseType.Equals(typeof(Enum)))
            {
                throw new ArgumentException("Can only convert an instance of enum.", "value");
            }

            string name = value.ToString();
            object[] attrs =
                value.GetType().GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attrs.Length > 0) ? ((DescriptionAttribute)attrs[0]).Description : name;
        }
    }
}