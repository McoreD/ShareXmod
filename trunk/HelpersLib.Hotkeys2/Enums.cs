﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace HelpersLib.Hotkeys2
{
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