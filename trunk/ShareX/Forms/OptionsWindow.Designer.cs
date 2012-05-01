﻿namespace ShareX.Forms
{
    partial class OptionsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Hotkeys");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Clipboard");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Shapes");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Capture", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Quality");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Resize");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Image Processing", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("After Upload");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Upload", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Paths");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Proxy");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Advanced");
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.tcBase = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.gbNotifications = new System.Windows.Forms.GroupBox();
            this.chkPlaySoundAfterUpload = new System.Windows.Forms.CheckBox();
            this.cbPlaySoundAfterCapture = new System.Windows.Forms.CheckBox();
            this.lblGeneralInfo = new System.Windows.Forms.Label();
            this.cbCheckUpdates = new System.Windows.Forms.CheckBox();
            this.cbStartWithWindows = new System.Windows.Forms.CheckBox();
            this.cbShowTray = new System.Windows.Forms.CheckBox();
            this.cbShellContextMenu = new System.Windows.Forms.CheckBox();
            this.tpAdvanced = new System.Windows.Forms.TabPage();
            this.panelAdvanced = new System.Windows.Forms.Panel();
            this.pgSettings = new System.Windows.Forms.PropertyGrid();
            this.tpCapture = new System.Windows.Forms.TabPage();
            this.panelCapture = new System.Windows.Forms.Panel();
            this.gbCaptureAfter = new System.Windows.Forms.GroupBox();
            this.chkCaptureAnnotateImage = new System.Windows.Forms.CheckBox();
            this.cbCaptureUploadImage = new System.Windows.Forms.CheckBox();
            this.cbCaptureSaveImage = new System.Windows.Forms.CheckBox();
            this.cbCaptureCopyImage = new System.Windows.Forms.CheckBox();
            this.cbCaptureShadow = new System.Windows.Forms.CheckBox();
            this.cbShowCursor = new System.Windows.Forms.CheckBox();
            this.cbCaptureTransparent = new System.Windows.Forms.CheckBox();
            this.tpShapes = new System.Windows.Forms.TabPage();
            this.panelShapes = new System.Windows.Forms.Panel();
            this.cbShapeForceWindowCapture = new System.Windows.Forms.CheckBox();
            this.cbShapeIncludeControls = new System.Windows.Forms.CheckBox();
            this.lblFixedShapeSizeHeight = new System.Windows.Forms.Label();
            this.cbDrawBorder = new System.Windows.Forms.CheckBox();
            this.lblFixedShapeSizeWidth = new System.Windows.Forms.Label();
            this.cbQuickCrop = new System.Windows.Forms.CheckBox();
            this.nudFixedShapeSizeHeight = new System.Windows.Forms.NumericUpDown();
            this.cbDrawCheckerboard = new System.Windows.Forms.CheckBox();
            this.nudFixedShapeSizeWidth = new System.Windows.Forms.NumericUpDown();
            this.cbFixedShapeSize = new System.Windows.Forms.CheckBox();
            this.tpProxy = new System.Windows.Forms.TabPage();
            this.panelProxy = new System.Windows.Forms.Panel();
            this.btnAutofillProxy = new System.Windows.Forms.Button();
            this.pgProxy = new System.Windows.Forms.PropertyGrid();
            this.tpClipboardUpload = new System.Windows.Forms.TabPage();
            this.panelClipboardUpload = new System.Windows.Forms.Panel();
            this.cbClipboardUploadAutoDetectURL = new System.Windows.Forms.CheckBox();
            this.lblClipboardUploadInfo = new System.Windows.Forms.Label();
            this.lblNameFormatPatternPreview = new System.Windows.Forms.Label();
            this.lblNameFormatPattern = new System.Windows.Forms.Label();
            this.btnNameFormatPatternHelp = new System.Windows.Forms.Button();
            this.txtNameFormatPattern = new System.Windows.Forms.TextBox();
            this.tpUpload = new System.Windows.Forms.TabPage();
            this.panelUpload = new System.Windows.Forms.Panel();
            this.lblUploadLimitHint = new System.Windows.Forms.Label();
            this.nudUploadLimit = new System.Windows.Forms.NumericUpDown();
            this.lblUploadLimit = new System.Windows.Forms.Label();
            this.lblBufferSize = new System.Windows.Forms.Label();
            this.lblBufferSizeInfo = new System.Windows.Forms.Label();
            this.cbBufferSize = new System.Windows.Forms.ComboBox();
            this.tpHotkeys = new System.Windows.Forms.TabPage();
            this.panelHotkeys = new System.Windows.Forms.Panel();
            this.hmHotkeys = new HelpersLib.Hotkeys2.HotkeyManagerControl();
            this.tpImageQuality = new System.Windows.Forms.TabPage();
            this.panelImageQuality = new System.Windows.Forms.Panel();
            this.cbImageUseSmoothScaling = new System.Windows.Forms.CheckBox();
            this.cbImageKeepAspectRatio = new System.Windows.Forms.CheckBox();
            this.cbImageAutoResize = new System.Windows.Forms.CheckBox();
            this.gbImageScaleSettings = new System.Windows.Forms.GroupBox();
            this.rbImageScaleTypePercentage = new System.Windows.Forms.RadioButton();
            this.lblImageScaleToHeight2 = new System.Windows.Forms.Label();
            this.rbImageScaleTypeToWidth = new System.Windows.Forms.RadioButton();
            this.lblImageScaleSpecificWidth2 = new System.Windows.Forms.Label();
            this.rbImageScaleTypeToHeight = new System.Windows.Forms.RadioButton();
            this.lblImageScaleSpecificHeight2 = new System.Windows.Forms.Label();
            this.rbImageScaleTypeSpecific = new System.Windows.Forms.RadioButton();
            this.lblImageScaleToWidth2 = new System.Windows.Forms.Label();
            this.lblImageScalePercentageWidth = new System.Windows.Forms.Label();
            this.lblImageScalePercentageHeight2 = new System.Windows.Forms.Label();
            this.nudImageScalePercentageWidth = new System.Windows.Forms.NumericUpDown();
            this.lblImageScalePercentageWidth2 = new System.Windows.Forms.Label();
            this.lblImageScalePercentageHeight = new System.Windows.Forms.Label();
            this.nudImageScaleToHeight = new System.Windows.Forms.NumericUpDown();
            this.nudImageScalePercentageHeight = new System.Windows.Forms.NumericUpDown();
            this.nudImageScaleToWidth = new System.Windows.Forms.NumericUpDown();
            this.lblImageScaleToWidth = new System.Windows.Forms.Label();
            this.nudImageScaleSpecificHeight = new System.Windows.Forms.NumericUpDown();
            this.lblImageScaleToHeight = new System.Windows.Forms.Label();
            this.lblImageScaleSpecificHeight = new System.Windows.Forms.Label();
            this.lblImageScaleSpecificWidth = new System.Windows.Forms.Label();
            this.nudImageScaleSpecificWidth = new System.Windows.Forms.NumericUpDown();
            this.tpImageResize = new System.Windows.Forms.TabPage();
            this.panelImageResize = new System.Windows.Forms.Panel();
            this.lblImageFormat = new System.Windows.Forms.Label();
            this.lblUseImageFormat2AfterHint = new System.Windows.Forms.Label();
            this.cbImageFormat = new System.Windows.Forms.ComboBox();
            this.lblImageJPEGQualityHint = new System.Windows.Forms.Label();
            this.lblImageJPEGQuality = new System.Windows.Forms.Label();
            this.cbImageGIFQuality = new System.Windows.Forms.ComboBox();
            this.lblImageGIFQuality = new System.Windows.Forms.Label();
            this.cbImageFormat2 = new System.Windows.Forms.ComboBox();
            this.nudImageJPEGQuality = new System.Windows.Forms.NumericUpDown();
            this.lblImageFormat2 = new System.Windows.Forms.Label();
            this.nudUseImageFormat2After = new System.Windows.Forms.NumericUpDown();
            this.lblUseImageFormat2After = new System.Windows.Forms.Label();
            this.tpPaths = new System.Windows.Forms.TabPage();
            this.panelPaths = new System.Windows.Forms.Panel();
            this.gbPathRoot = new System.Windows.Forms.GroupBox();
            this.lblOpenZUploaderPath = new System.Windows.Forms.Label();
            this.btnOpenZUploaderPath = new System.Windows.Forms.Button();
            this.gbScreenshots = new System.Windows.Forms.GroupBox();
            this.txtSaveImageSubFolderPatternPreview = new System.Windows.Forms.TextBox();
            this.lblSaveImageSubFolderPattern = new System.Windows.Forms.Label();
            this.txtSaveImageSubFolderPattern = new System.Windows.Forms.TextBox();
            this.btnBrowseScreenshotsDir = new System.Windows.Forms.Button();
            this.txtScreenshotsPath = new System.Windows.Forms.TextBox();
            this.gbUploadersConfig = new System.Windows.Forms.GroupBox();
            this.btnLoadUploadersConfig = new System.Windows.Forms.Button();
            this.btnBrowseCustomUploadersConfigPath = new System.Windows.Forms.Button();
            this.txtCustomUploadersConfigPath = new System.Windows.Forms.TextBox();
            this.cbUseCustomUploadersConfigPath = new System.Windows.Forms.CheckBox();
            this.gbHistory = new System.Windows.Forms.GroupBox();
            this.nudHistoryMaxItemCount = new System.Windows.Forms.NumericUpDown();
            this.lblHistoryMaxItemCount = new System.Windows.Forms.Label();
            this.btnBrowseCustomHistoryPath = new System.Windows.Forms.Button();
            this.txtCustomHistoryPath = new System.Windows.Forms.TextBox();
            this.cbUseCustomHistoryPath = new System.Windows.Forms.CheckBox();
            this.cbHistorySave = new System.Windows.Forms.CheckBox();
            this.tpAfterUpload = new System.Windows.Forms.TabPage();
            this.panelAfterUpload = new System.Windows.Forms.Panel();
            this.cbURLShortenAfterUpload = new System.Windows.Forms.CheckBox();
            this.cbClipboardAutoCopy = new System.Windows.Forms.CheckBox();
            this.tlpMain.SuspendLayout();
            this.tcBase.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.gbNotifications.SuspendLayout();
            this.tpAdvanced.SuspendLayout();
            this.panelAdvanced.SuspendLayout();
            this.tpCapture.SuspendLayout();
            this.panelCapture.SuspendLayout();
            this.gbCaptureAfter.SuspendLayout();
            this.tpShapes.SuspendLayout();
            this.panelShapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFixedShapeSizeHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFixedShapeSizeWidth)).BeginInit();
            this.tpProxy.SuspendLayout();
            this.panelProxy.SuspendLayout();
            this.tpClipboardUpload.SuspendLayout();
            this.panelClipboardUpload.SuspendLayout();
            this.tpUpload.SuspendLayout();
            this.panelUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUploadLimit)).BeginInit();
            this.tpHotkeys.SuspendLayout();
            this.panelHotkeys.SuspendLayout();
            this.tpImageQuality.SuspendLayout();
            this.panelImageQuality.SuspendLayout();
            this.gbImageScaleSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageScalePercentageWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageScaleToHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageScalePercentageHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageScaleToWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageScaleSpecificHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageScaleSpecificWidth)).BeginInit();
            this.tpImageResize.SuspendLayout();
            this.panelImageResize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageJPEGQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUseImageFormat2After)).BeginInit();
            this.tpPaths.SuspendLayout();
            this.panelPaths.SuspendLayout();
            this.gbPathRoot.SuspendLayout();
            this.gbScreenshots.SuspendLayout();
            this.gbUploadersConfig.SuspendLayout();
            this.gbHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHistoryMaxItemCount)).BeginInit();
            this.tpAfterUpload.SuspendLayout();
            this.panelAfterUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpMain.Controls.Add(this.tvMain, 0, 0);
            this.tlpMain.Controls.Add(this.tcBase, 1, 0);
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(696, 552);
            this.tlpMain.TabIndex = 0;
            // 
            // tvMain
            // 
            this.tvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMain.Location = new System.Drawing.Point(3, 3);
            this.tvMain.Name = "tvMain";
            treeNode1.Name = "tnGeneral";
            treeNode1.Tag = "panelGeneral";
            treeNode1.Text = "General";
            treeNode2.Name = "tnHotkeys";
            treeNode2.Text = "Hotkeys";
            treeNode3.Name = "tnClipboardUpload";
            treeNode3.Text = "Clipboard";
            treeNode4.Name = "tnShapes";
            treeNode4.Tag = "panelShapes";
            treeNode4.Text = "Shapes";
            treeNode5.Name = "tnCapture";
            treeNode5.Tag = "panelCapture";
            treeNode5.Text = "Capture";
            treeNode6.Name = "tnImageQuality";
            treeNode6.Text = "Quality";
            treeNode7.Name = "tnImageResize";
            treeNode7.Text = "Resize";
            treeNode8.Name = "tnImage";
            treeNode8.Text = "Image Processing";
            treeNode9.Name = "tnAfterUpload";
            treeNode9.Text = "After Upload";
            treeNode10.Name = "tnUpload";
            treeNode10.Text = "Upload";
            treeNode11.Name = "tnPaths";
            treeNode11.Text = "Paths";
            treeNode12.Name = "tnProxy";
            treeNode12.Text = "Proxy";
            treeNode13.Name = "tnAdvanced";
            treeNode13.Text = "Advanced";
            this.tvMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode5,
            treeNode8,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            this.tvMain.Size = new System.Drawing.Size(133, 546);
            this.tvMain.TabIndex = 0;
            // 
            // tcBase
            // 
            this.tcBase.Controls.Add(this.tpGeneral);
            this.tcBase.Controls.Add(this.tpAdvanced);
            this.tcBase.Controls.Add(this.tpCapture);
            this.tcBase.Controls.Add(this.tpShapes);
            this.tcBase.Controls.Add(this.tpProxy);
            this.tcBase.Controls.Add(this.tpClipboardUpload);
            this.tcBase.Controls.Add(this.tpUpload);
            this.tcBase.Controls.Add(this.tpHotkeys);
            this.tcBase.Controls.Add(this.tpImageQuality);
            this.tcBase.Controls.Add(this.tpImageResize);
            this.tcBase.Controls.Add(this.tpPaths);
            this.tcBase.Controls.Add(this.tpAfterUpload);
            this.tcBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBase.Location = new System.Drawing.Point(142, 3);
            this.tcBase.Name = "tcBase";
            this.tcBase.SelectedIndex = 0;
            this.tcBase.Size = new System.Drawing.Size(551, 546);
            this.tcBase.TabIndex = 1;
            this.tcBase.Visible = false;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.panelGeneral);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Size = new System.Drawing.Size(543, 488);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.panelGeneral.Controls.Add(this.gbNotifications);
            this.panelGeneral.Controls.Add(this.lblGeneralInfo);
            this.panelGeneral.Controls.Add(this.cbCheckUpdates);
            this.panelGeneral.Controls.Add(this.cbStartWithWindows);
            this.panelGeneral.Controls.Add(this.cbShowTray);
            this.panelGeneral.Controls.Add(this.cbShellContextMenu);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(543, 488);
            this.panelGeneral.TabIndex = 3;
            // 
            // gbNotifications
            // 
            this.gbNotifications.Controls.Add(this.chkPlaySoundAfterUpload);
            this.gbNotifications.Controls.Add(this.cbPlaySoundAfterCapture);
            this.gbNotifications.Location = new System.Drawing.Point(16, 136);
            this.gbNotifications.Name = "gbNotifications";
            this.gbNotifications.Size = new System.Drawing.Size(512, 80);
            this.gbNotifications.TabIndex = 9;
            this.gbNotifications.TabStop = false;
            this.gbNotifications.Text = "Notifications";
            // 
            // chkPlaySoundAfterUpload
            // 
            this.chkPlaySoundAfterUpload.AutoSize = true;
            this.chkPlaySoundAfterUpload.Location = new System.Drawing.Point(16, 48);
            this.chkPlaySoundAfterUpload.Name = "chkPlaySoundAfterUpload";
            this.chkPlaySoundAfterUpload.Size = new System.Drawing.Size(199, 17);
            this.chkPlaySoundAfterUpload.TabIndex = 9;
            this.chkPlaySoundAfterUpload.Text = "Play sound after upload is completed";
            this.chkPlaySoundAfterUpload.UseVisualStyleBackColor = true;
            this.chkPlaySoundAfterUpload.CheckedChanged += new System.EventHandler(this.chkPlaySoundAfterUpload_CheckedChanged);
            // 
            // cbPlaySoundAfterCapture
            // 
            this.cbPlaySoundAfterCapture.AutoSize = true;
            this.cbPlaySoundAfterCapture.Location = new System.Drawing.Point(16, 24);
            this.cbPlaySoundAfterCapture.Name = "cbPlaySoundAfterCapture";
            this.cbPlaySoundAfterCapture.Size = new System.Drawing.Size(180, 17);
            this.cbPlaySoundAfterCapture.TabIndex = 8;
            this.cbPlaySoundAfterCapture.Text = "Play sound after capture is made";
            this.cbPlaySoundAfterCapture.UseVisualStyleBackColor = true;
            this.cbPlaySoundAfterCapture.CheckedChanged += new System.EventHandler(this.cbPlaySoundAfterCapture_CheckedChanged);
            // 
            // lblGeneralInfo
            // 
            this.lblGeneralInfo.BackColor = System.Drawing.Color.DimGray;
            this.lblGeneralInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGeneralInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGeneralInfo.ForeColor = System.Drawing.Color.White;
            this.lblGeneralInfo.Location = new System.Drawing.Point(0, 459);
            this.lblGeneralInfo.Name = "lblGeneralInfo";
            this.lblGeneralInfo.Size = new System.Drawing.Size(543, 29);
            this.lblGeneralInfo.TabIndex = 4;
            this.lblGeneralInfo.Text = "Shell context menu is Windows Explorer right click menu for files and folders.";
            this.lblGeneralInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCheckUpdates
            // 
            this.cbCheckUpdates.AutoSize = true;
            this.cbCheckUpdates.Location = new System.Drawing.Point(16, 88);
            this.cbCheckUpdates.Name = "cbCheckUpdates";
            this.cbCheckUpdates.Size = new System.Drawing.Size(209, 17);
            this.cbCheckUpdates.TabIndex = 3;
            this.cbCheckUpdates.Text = "Automatically check updates at startup";
            this.cbCheckUpdates.UseVisualStyleBackColor = true;
            this.cbCheckUpdates.CheckedChanged += new System.EventHandler(this.cbCheckUpdates_CheckedChanged);
            // 
            // cbStartWithWindows
            // 
            this.cbStartWithWindows.AutoSize = true;
            this.cbStartWithWindows.Location = new System.Drawing.Point(16, 40);
            this.cbStartWithWindows.Name = "cbStartWithWindows";
            this.cbStartWithWindows.Size = new System.Drawing.Size(155, 17);
            this.cbStartWithWindows.TabIndex = 1;
            this.cbStartWithWindows.Text = "Start ShareX with Windows";
            this.cbStartWithWindows.UseVisualStyleBackColor = true;
            this.cbStartWithWindows.CheckedChanged += new System.EventHandler(this.cbStartWithWindows_CheckedChanged);
            // 
            // cbShowTray
            // 
            this.cbShowTray.AutoSize = true;
            this.cbShowTray.Location = new System.Drawing.Point(16, 16);
            this.cbShowTray.Name = "cbShowTray";
            this.cbShowTray.Size = new System.Drawing.Size(134, 17);
            this.cbShowTray.TabIndex = 0;
            this.cbShowTray.Text = "Show ShareX tray icon";
            this.cbShowTray.UseVisualStyleBackColor = true;
            this.cbShowTray.CheckedChanged += new System.EventHandler(this.cbShowTray_CheckedChanged);
            // 
            // cbShellContextMenu
            // 
            this.cbShellContextMenu.AutoSize = true;
            this.cbShellContextMenu.Location = new System.Drawing.Point(16, 64);
            this.cbShellContextMenu.Name = "cbShellContextMenu";
            this.cbShellContextMenu.Size = new System.Drawing.Size(270, 17);
            this.cbShellContextMenu.TabIndex = 2;
            this.cbShellContextMenu.Text = "Show \"Upload using ShareX\" in Shell context menu";
            this.cbShellContextMenu.UseVisualStyleBackColor = true;
            this.cbShellContextMenu.CheckedChanged += new System.EventHandler(this.cbShellContextMenu_CheckedChanged);
            // 
            // tpAdvanced
            // 
            this.tpAdvanced.Controls.Add(this.panelAdvanced);
            this.tpAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tpAdvanced.Name = "tpAdvanced";
            this.tpAdvanced.Size = new System.Drawing.Size(543, 488);
            this.tpAdvanced.TabIndex = 1;
            this.tpAdvanced.Text = "Advanced";
            this.tpAdvanced.UseVisualStyleBackColor = true;
            // 
            // panelAdvanced
            // 
            this.panelAdvanced.BackColor = System.Drawing.SystemColors.Control;
            this.panelAdvanced.Controls.Add(this.pgSettings);
            this.panelAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdvanced.Location = new System.Drawing.Point(0, 0);
            this.panelAdvanced.Name = "panelAdvanced";
            this.panelAdvanced.Size = new System.Drawing.Size(556, 534);
            this.panelAdvanced.TabIndex = 0;
            // 
            // pgSettings
            // 
            this.pgSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgSettings.Location = new System.Drawing.Point(0, 0);
            this.pgSettings.Name = "pgSettings";
            this.pgSettings.Size = new System.Drawing.Size(556, 534);
            this.pgSettings.TabIndex = 1;
            // 
            // tpCapture
            // 
            this.tpCapture.Controls.Add(this.panelCapture);
            this.tpCapture.Location = new System.Drawing.Point(4, 22);
            this.tpCapture.Name = "tpCapture";
            this.tpCapture.Padding = new System.Windows.Forms.Padding(3);
            this.tpCapture.Size = new System.Drawing.Size(543, 488);
            this.tpCapture.TabIndex = 2;
            this.tpCapture.Text = "Capture";
            this.tpCapture.UseVisualStyleBackColor = true;
            // 
            // panelCapture
            // 
            this.panelCapture.BackColor = System.Drawing.SystemColors.Control;
            this.panelCapture.Controls.Add(this.gbCaptureAfter);
            this.panelCapture.Controls.Add(this.cbCaptureShadow);
            this.panelCapture.Controls.Add(this.cbShowCursor);
            this.panelCapture.Controls.Add(this.cbCaptureTransparent);
            this.panelCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCapture.Location = new System.Drawing.Point(3, 3);
            this.panelCapture.Name = "panelCapture";
            this.panelCapture.Size = new System.Drawing.Size(537, 482);
            this.panelCapture.TabIndex = 1;
            // 
            // gbCaptureAfter
            // 
            this.gbCaptureAfter.Controls.Add(this.chkCaptureAnnotateImage);
            this.gbCaptureAfter.Controls.Add(this.cbCaptureUploadImage);
            this.gbCaptureAfter.Controls.Add(this.cbCaptureSaveImage);
            this.gbCaptureAfter.Controls.Add(this.cbCaptureCopyImage);
            this.gbCaptureAfter.Location = new System.Drawing.Point(16, 104);
            this.gbCaptureAfter.Name = "gbCaptureAfter";
            this.gbCaptureAfter.Size = new System.Drawing.Size(472, 128);
            this.gbCaptureAfter.TabIndex = 4;
            this.gbCaptureAfter.TabStop = false;
            this.gbCaptureAfter.Text = "After capture tasks";
            // 
            // chkCaptureAnnotateImage
            // 
            this.chkCaptureAnnotateImage.AutoSize = true;
            this.chkCaptureAnnotateImage.Location = new System.Drawing.Point(16, 24);
            this.chkCaptureAnnotateImage.Name = "chkCaptureAnnotateImage";
            this.chkCaptureAnnotateImage.Size = new System.Drawing.Size(101, 17);
            this.chkCaptureAnnotateImage.TabIndex = 0;
            this.chkCaptureAnnotateImage.Text = "Annotate Image";
            this.chkCaptureAnnotateImage.UseVisualStyleBackColor = true;
            this.chkCaptureAnnotateImage.CheckedChanged += new System.EventHandler(this.chkCaptureAnnotateImage_CheckedChanged);
            // 
            // cbCaptureUploadImage
            // 
            this.cbCaptureUploadImage.AutoSize = true;
            this.cbCaptureUploadImage.Location = new System.Drawing.Point(16, 96);
            this.cbCaptureUploadImage.Name = "cbCaptureUploadImage";
            this.cbCaptureUploadImage.Size = new System.Drawing.Size(126, 17);
            this.cbCaptureUploadImage.TabIndex = 8;
            this.cbCaptureUploadImage.Text = "Upload image to host";
            this.cbCaptureUploadImage.UseVisualStyleBackColor = true;
            this.cbCaptureUploadImage.CheckedChanged += new System.EventHandler(this.cbCaptureUploadImage_CheckedChanged);
            // 
            // cbCaptureSaveImage
            // 
            this.cbCaptureSaveImage.AutoSize = true;
            this.cbCaptureSaveImage.Location = new System.Drawing.Point(16, 72);
            this.cbCaptureSaveImage.Name = "cbCaptureSaveImage";
            this.cbCaptureSaveImage.Size = new System.Drawing.Size(110, 17);
            this.cbCaptureSaveImage.TabIndex = 2;
            this.cbCaptureSaveImage.Text = "Save image to file";
            this.cbCaptureSaveImage.UseVisualStyleBackColor = true;
            this.cbCaptureSaveImage.CheckedChanged += new System.EventHandler(this.cbCaptureSaveImage_CheckedChanged);
            // 
            // cbCaptureCopyImage
            // 
            this.cbCaptureCopyImage.AutoSize = true;
            this.cbCaptureCopyImage.Location = new System.Drawing.Point(16, 48);
            this.cbCaptureCopyImage.Name = "cbCaptureCopyImage";
            this.cbCaptureCopyImage.Size = new System.Drawing.Size(139, 17);
            this.cbCaptureCopyImage.TabIndex = 1;
            this.cbCaptureCopyImage.Text = "Copy image to clipboard\r\n";
            this.cbCaptureCopyImage.UseVisualStyleBackColor = true;
            this.cbCaptureCopyImage.CheckedChanged += new System.EventHandler(this.cbCaptureCopyImage_CheckedChanged);
            // 
            // cbCaptureShadow
            // 
            this.cbCaptureShadow.AutoSize = true;
            this.cbCaptureShadow.Location = new System.Drawing.Point(16, 64);
            this.cbCaptureShadow.Name = "cbCaptureShadow";
            this.cbCaptureShadow.Size = new System.Drawing.Size(274, 17);
            this.cbCaptureShadow.TabIndex = 2;
            this.cbCaptureShadow.Text = "Capture window with shadow (requires transparency)";
            this.cbCaptureShadow.UseVisualStyleBackColor = true;
            this.cbCaptureShadow.CheckedChanged += new System.EventHandler(this.cbCaptureShadow_CheckedChanged);
            // 
            // cbShowCursor
            // 
            this.cbShowCursor.AutoSize = true;
            this.cbShowCursor.Location = new System.Drawing.Point(16, 16);
            this.cbShowCursor.Name = "cbShowCursor";
            this.cbShowCursor.Size = new System.Drawing.Size(156, 17);
            this.cbShowCursor.TabIndex = 0;
            this.cbShowCursor.Text = "Show cursor in screenshots";
            this.cbShowCursor.UseVisualStyleBackColor = true;
            this.cbShowCursor.CheckedChanged += new System.EventHandler(this.cbShowCursor_CheckedChanged);
            // 
            // cbCaptureTransparent
            // 
            this.cbCaptureTransparent.AutoSize = true;
            this.cbCaptureTransparent.Location = new System.Drawing.Point(16, 40);
            this.cbCaptureTransparent.Name = "cbCaptureTransparent";
            this.cbCaptureTransparent.Size = new System.Drawing.Size(188, 17);
            this.cbCaptureTransparent.TabIndex = 1;
            this.cbCaptureTransparent.Text = "Capture window with transparency";
            this.cbCaptureTransparent.UseVisualStyleBackColor = true;
            this.cbCaptureTransparent.CheckedChanged += new System.EventHandler(this.cbCaptureTransparent_CheckedChanged);
            // 
            // tpShapes
            // 
            this.tpShapes.Controls.Add(this.panelShapes);
            this.tpShapes.Location = new System.Drawing.Point(4, 22);
            this.tpShapes.Name = "tpShapes";
            this.tpShapes.Padding = new System.Windows.Forms.Padding(3);
            this.tpShapes.Size = new System.Drawing.Size(543, 520);
            this.tpShapes.TabIndex = 3;
            this.tpShapes.Text = "Shapes";
            this.tpShapes.UseVisualStyleBackColor = true;
            // 
            // panelShapes
            // 
            this.panelShapes.BackColor = System.Drawing.SystemColors.Control;
            this.panelShapes.Controls.Add(this.cbShapeForceWindowCapture);
            this.panelShapes.Controls.Add(this.cbShapeIncludeControls);
            this.panelShapes.Controls.Add(this.lblFixedShapeSizeHeight);
            this.panelShapes.Controls.Add(this.cbDrawBorder);
            this.panelShapes.Controls.Add(this.lblFixedShapeSizeWidth);
            this.panelShapes.Controls.Add(this.cbQuickCrop);
            this.panelShapes.Controls.Add(this.nudFixedShapeSizeHeight);
            this.panelShapes.Controls.Add(this.cbDrawCheckerboard);
            this.panelShapes.Controls.Add(this.nudFixedShapeSizeWidth);
            this.panelShapes.Controls.Add(this.cbFixedShapeSize);
            this.panelShapes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShapes.Location = new System.Drawing.Point(3, 3);
            this.panelShapes.Name = "panelShapes";
            this.panelShapes.Size = new System.Drawing.Size(537, 514);
            this.panelShapes.TabIndex = 2;
            // 
            // cbShapeForceWindowCapture
            // 
            this.cbShapeForceWindowCapture.AutoSize = true;
            this.cbShapeForceWindowCapture.Location = new System.Drawing.Point(16, 176);
            this.cbShapeForceWindowCapture.Name = "cbShapeForceWindowCapture";
            this.cbShapeForceWindowCapture.Size = new System.Drawing.Size(287, 17);
            this.cbShapeForceWindowCapture.TabIndex = 19;
            this.cbShapeForceWindowCapture.Text = "Use window capture mode for all rectangle type shapes";
            this.cbShapeForceWindowCapture.UseVisualStyleBackColor = true;
            this.cbShapeForceWindowCapture.CheckedChanged += new System.EventHandler(this.cbShapeForceWindowCapture_CheckedChanged);
            // 
            // cbShapeIncludeControls
            // 
            this.cbShapeIncludeControls.AutoSize = true;
            this.cbShapeIncludeControls.Location = new System.Drawing.Point(16, 152);
            this.cbShapeIncludeControls.Name = "cbShapeIncludeControls";
            this.cbShapeIncludeControls.Size = new System.Drawing.Size(329, 17);
            this.cbShapeIncludeControls.TabIndex = 18;
            this.cbShapeIncludeControls.Text = "Allow capturing controls in window capture (buttons, panels etc.)";
            this.cbShapeIncludeControls.UseVisualStyleBackColor = true;
            this.cbShapeIncludeControls.CheckedChanged += new System.EventHandler(this.cbShapeIncludeControls_CheckedChanged);
            // 
            // lblFixedShapeSizeHeight
            // 
            this.lblFixedShapeSizeHeight.AutoSize = true;
            this.lblFixedShapeSizeHeight.Location = new System.Drawing.Point(160, 116);
            this.lblFixedShapeSizeHeight.Name = "lblFixedShapeSizeHeight";
            this.lblFixedShapeSizeHeight.Size = new System.Drawing.Size(41, 13);
            this.lblFixedShapeSizeHeight.TabIndex = 16;
            this.lblFixedShapeSizeHeight.Text = "Height:";
            // 
            // cbDrawBorder
            // 
            this.cbDrawBorder.AutoSize = true;
            this.cbDrawBorder.Location = new System.Drawing.Point(16, 16);
            this.cbDrawBorder.Name = "cbDrawBorder";
            this.cbDrawBorder.Size = new System.Drawing.Size(170, 17);
            this.cbDrawBorder.TabIndex = 10;
            this.cbDrawBorder.Text = "Draw border around the shape";
            this.cbDrawBorder.UseVisualStyleBackColor = true;
            this.cbDrawBorder.CheckedChanged += new System.EventHandler(this.cbDrawBorder_CheckedChanged);
            // 
            // lblFixedShapeSizeWidth
            // 
            this.lblFixedShapeSizeWidth.AutoSize = true;
            this.lblFixedShapeSizeWidth.Location = new System.Drawing.Point(44, 116);
            this.lblFixedShapeSizeWidth.Name = "lblFixedShapeSizeWidth";
            this.lblFixedShapeSizeWidth.Size = new System.Drawing.Size(38, 13);
            this.lblFixedShapeSizeWidth.TabIndex = 14;
            this.lblFixedShapeSizeWidth.Text = "Width:";
            // 
            // cbQuickCrop
            // 
            this.cbQuickCrop.AutoSize = true;
            this.cbQuickCrop.Location = new System.Drawing.Point(16, 64);
            this.cbQuickCrop.Name = "cbQuickCrop";
            this.cbQuickCrop.Size = new System.Drawing.Size(455, 17);
            this.cbQuickCrop.TabIndex = 12;
            this.cbQuickCrop.Text = "Complete capture as soon as the mouse button is released, except when capturing p" +
    "olygon";
            this.cbQuickCrop.UseVisualStyleBackColor = true;
            this.cbQuickCrop.CheckedChanged += new System.EventHandler(this.cbQuickCrop_CheckedChanged);
            // 
            // nudFixedShapeSizeHeight
            // 
            this.nudFixedShapeSizeHeight.Location = new System.Drawing.Point(208, 112);
            this.nudFixedShapeSizeHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudFixedShapeSizeHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFixedShapeSizeHeight.Name = "nudFixedShapeSizeHeight";
            this.nudFixedShapeSizeHeight.Size = new System.Drawing.Size(56, 20);
            this.nudFixedShapeSizeHeight.TabIndex = 17;
            this.nudFixedShapeSizeHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFixedShapeSizeHeight.ValueChanged += new System.EventHandler(this.nudFixedShapeSizeHeight_ValueChanged);
            // 
            // cbDrawCheckerboard
            // 
            this.cbDrawCheckerboard.AutoSize = true;
            this.cbDrawCheckerboard.Location = new System.Drawing.Point(16, 40);
            this.cbDrawCheckerboard.Name = "cbDrawCheckerboard";
            this.cbDrawCheckerboard.Size = new System.Drawing.Size(287, 17);
            this.cbDrawCheckerboard.TabIndex = 11;
            this.cbDrawCheckerboard.Text = "Draw checkerboard pattern replacing transparent areas";
            this.cbDrawCheckerboard.UseVisualStyleBackColor = true;
            this.cbDrawCheckerboard.CheckedChanged += new System.EventHandler(this.cbDrawCheckerboard_CheckedChanged);
            // 
            // nudFixedShapeSizeWidth
            // 
            this.nudFixedShapeSizeWidth.Location = new System.Drawing.Point(88, 112);
            this.nudFixedShapeSizeWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudFixedShapeSizeWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFixedShapeSizeWidth.Name = "nudFixedShapeSizeWidth";
            this.nudFixedShapeSizeWidth.Size = new System.Drawing.Size(56, 20);
            this.nudFixedShapeSizeWidth.TabIndex = 15;
            this.nudFixedShapeSizeWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFixedShapeSizeWidth.ValueChanged += new System.EventHandler(this.nudFixedShapeSizeWidth_ValueChanged);
            // 
            // cbFixedShapeSize
            // 
            this.cbFixedShapeSize.AutoSize = true;
            this.cbFixedShapeSize.Location = new System.Drawing.Point(16, 88);
            this.cbFixedShapeSize.Name = "cbFixedShapeSize";
            this.cbFixedShapeSize.Size = new System.Drawing.Size(107, 17);
            this.cbFixedShapeSize.TabIndex = 13;
            this.cbFixedShapeSize.Text = "Fixed shape size:";
            this.cbFixedShapeSize.UseVisualStyleBackColor = true;
            this.cbFixedShapeSize.CheckedChanged += new System.EventHandler(this.cbFixedShapeSize_CheckedChanged);
            // 
            // tpProxy
            // 
            this.tpProxy.Controls.Add(this.panelProxy);
            this.tpProxy.Location = new System.Drawing.Point(4, 22);
            this.tpProxy.Name = "tpProxy";
            this.tpProxy.Padding = new System.Windows.Forms.Padding(3);
            this.tpProxy.Size = new System.Drawing.Size(543, 488);
            this.tpProxy.TabIndex = 4;
            this.tpProxy.Text = "Proxy";
            this.tpProxy.UseVisualStyleBackColor = true;
            // 
            // panelProxy
            // 
            this.panelProxy.Controls.Add(this.btnAutofillProxy);
            this.panelProxy.Controls.Add(this.pgProxy);
            this.panelProxy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProxy.Location = new System.Drawing.Point(3, 3);
            this.panelProxy.Name = "panelProxy";
            this.panelProxy.Size = new System.Drawing.Size(537, 482);
            this.panelProxy.TabIndex = 4;
            // 
            // btnAutofillProxy
            // 
            this.btnAutofillProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutofillProxy.Location = new System.Drawing.Point(452, 446);
            this.btnAutofillProxy.Name = "btnAutofillProxy";
            this.btnAutofillProxy.Size = new System.Drawing.Size(75, 23);
            this.btnAutofillProxy.TabIndex = 3;
            this.btnAutofillProxy.Text = "Autofill";
            this.btnAutofillProxy.UseVisualStyleBackColor = true;
            this.btnAutofillProxy.Click += new System.EventHandler(this.btnAutofillProxy_Click);
            // 
            // pgProxy
            // 
            this.pgProxy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgProxy.Location = new System.Drawing.Point(0, 0);
            this.pgProxy.Name = "pgProxy";
            this.pgProxy.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgProxy.Size = new System.Drawing.Size(537, 482);
            this.pgProxy.TabIndex = 2;
            this.pgProxy.ToolbarVisible = false;
            // 
            // tpClipboardUpload
            // 
            this.tpClipboardUpload.Controls.Add(this.panelClipboardUpload);
            this.tpClipboardUpload.Location = new System.Drawing.Point(4, 22);
            this.tpClipboardUpload.Name = "tpClipboardUpload";
            this.tpClipboardUpload.Padding = new System.Windows.Forms.Padding(3);
            this.tpClipboardUpload.Size = new System.Drawing.Size(543, 488);
            this.tpClipboardUpload.TabIndex = 5;
            this.tpClipboardUpload.Text = "Clipboard Upload";
            this.tpClipboardUpload.UseVisualStyleBackColor = true;
            // 
            // panelClipboardUpload
            // 
            this.panelClipboardUpload.Controls.Add(this.cbClipboardUploadAutoDetectURL);
            this.panelClipboardUpload.Controls.Add(this.lblClipboardUploadInfo);
            this.panelClipboardUpload.Controls.Add(this.lblNameFormatPatternPreview);
            this.panelClipboardUpload.Controls.Add(this.lblNameFormatPattern);
            this.panelClipboardUpload.Controls.Add(this.btnNameFormatPatternHelp);
            this.panelClipboardUpload.Controls.Add(this.txtNameFormatPattern);
            this.panelClipboardUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClipboardUpload.Location = new System.Drawing.Point(3, 3);
            this.panelClipboardUpload.Name = "panelClipboardUpload";
            this.panelClipboardUpload.Size = new System.Drawing.Size(550, 528);
            this.panelClipboardUpload.TabIndex = 5;
            // 
            // cbClipboardUploadAutoDetectURL
            // 
            this.cbClipboardUploadAutoDetectURL.AutoSize = true;
            this.cbClipboardUploadAutoDetectURL.Location = new System.Drawing.Point(16, 16);
            this.cbClipboardUploadAutoDetectURL.Name = "cbClipboardUploadAutoDetectURL";
            this.cbClipboardUploadAutoDetectURL.Size = new System.Drawing.Size(401, 17);
            this.cbClipboardUploadAutoDetectURL.TabIndex = 6;
            this.cbClipboardUploadAutoDetectURL.Text = "Automatically detect URL when performing Text Upload and use URL shortener";
            this.cbClipboardUploadAutoDetectURL.UseVisualStyleBackColor = true;
            this.cbClipboardUploadAutoDetectURL.CheckedChanged += new System.EventHandler(this.cbClipboardUploadAutoDetectURL_CheckedChanged);
            // 
            // lblClipboardUploadInfo
            // 
            this.lblClipboardUploadInfo.BackColor = System.Drawing.Color.DimGray;
            this.lblClipboardUploadInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClipboardUploadInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblClipboardUploadInfo.ForeColor = System.Drawing.Color.White;
            this.lblClipboardUploadInfo.Location = new System.Drawing.Point(0, 499);
            this.lblClipboardUploadInfo.Name = "lblClipboardUploadInfo";
            this.lblClipboardUploadInfo.Size = new System.Drawing.Size(550, 29);
            this.lblClipboardUploadInfo.TabIndex = 11;
            this.lblClipboardUploadInfo.Text = "Clipboard upload automatically detects the data type and selects the upload servi" +
    "ce accordingly.";
            this.lblClipboardUploadInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameFormatPatternPreview
            // 
            this.lblNameFormatPatternPreview.AutoSize = true;
            this.lblNameFormatPatternPreview.Location = new System.Drawing.Point(16, 104);
            this.lblNameFormatPatternPreview.Name = "lblNameFormatPatternPreview";
            this.lblNameFormatPatternPreview.Size = new System.Drawing.Size(48, 13);
            this.lblNameFormatPatternPreview.TabIndex = 10;
            this.lblNameFormatPatternPreview.Text = "Preview:";
            // 
            // lblNameFormatPattern
            // 
            this.lblNameFormatPattern.AutoSize = true;
            this.lblNameFormatPattern.Location = new System.Drawing.Point(16, 48);
            this.lblNameFormatPattern.Name = "lblNameFormatPattern";
            this.lblNameFormatPattern.Size = new System.Drawing.Size(362, 13);
            this.lblNameFormatPattern.TabIndex = 7;
            this.lblNameFormatPattern.Text = "Clipboard upload name pattern for image and text (Not image file or text file):";
            // 
            // btnNameFormatPatternHelp
            // 
            this.btnNameFormatPatternHelp.Location = new System.Drawing.Point(440, 72);
            this.btnNameFormatPatternHelp.Name = "btnNameFormatPatternHelp";
            this.btnNameFormatPatternHelp.Size = new System.Drawing.Size(24, 23);
            this.btnNameFormatPatternHelp.TabIndex = 9;
            this.btnNameFormatPatternHelp.Text = "?";
            this.btnNameFormatPatternHelp.UseVisualStyleBackColor = true;
            this.btnNameFormatPatternHelp.Click += new System.EventHandler(this.btnNameFormatPatternHelp_Click);
            // 
            // txtNameFormatPattern
            // 
            this.txtNameFormatPattern.Location = new System.Drawing.Point(16, 72);
            this.txtNameFormatPattern.Name = "txtNameFormatPattern";
            this.txtNameFormatPattern.Size = new System.Drawing.Size(416, 20);
            this.txtNameFormatPattern.TabIndex = 8;
            this.txtNameFormatPattern.TextChanged += new System.EventHandler(this.txtNameFormatPattern_TextChanged);
            // 
            // tpUpload
            // 
            this.tpUpload.Controls.Add(this.panelUpload);
            this.tpUpload.Location = new System.Drawing.Point(4, 22);
            this.tpUpload.Name = "tpUpload";
            this.tpUpload.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpload.Size = new System.Drawing.Size(543, 488);
            this.tpUpload.TabIndex = 6;
            this.tpUpload.Text = "Upload";
            this.tpUpload.UseVisualStyleBackColor = true;
            // 
            // panelUpload
            // 
            this.panelUpload.Controls.Add(this.lblUploadLimitHint);
            this.panelUpload.Controls.Add(this.nudUploadLimit);
            this.panelUpload.Controls.Add(this.lblUploadLimit);
            this.panelUpload.Controls.Add(this.lblBufferSize);
            this.panelUpload.Controls.Add(this.lblBufferSizeInfo);
            this.panelUpload.Controls.Add(this.cbBufferSize);
            this.panelUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUpload.Location = new System.Drawing.Point(3, 3);
            this.panelUpload.Name = "panelUpload";
            this.panelUpload.Size = new System.Drawing.Size(537, 482);
            this.panelUpload.TabIndex = 0;
            // 
            // lblUploadLimitHint
            // 
            this.lblUploadLimitHint.AutoSize = true;
            this.lblUploadLimitHint.Location = new System.Drawing.Point(216, 24);
            this.lblUploadLimitHint.Name = "lblUploadLimitHint";
            this.lblUploadLimitHint.Size = new System.Drawing.Size(90, 13);
            this.lblUploadLimitHint.TabIndex = 12;
            this.lblUploadLimitHint.Text = "0 - 25 (0 disables)";
            // 
            // nudUploadLimit
            // 
            this.nudUploadLimit.Location = new System.Drawing.Point(152, 20);
            this.nudUploadLimit.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudUploadLimit.Name = "nudUploadLimit";
            this.nudUploadLimit.Size = new System.Drawing.Size(56, 20);
            this.nudUploadLimit.TabIndex = 11;
            this.nudUploadLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudUploadLimit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudUploadLimit.ValueChanged += new System.EventHandler(this.nudUploadLimit_ValueChanged);
            // 
            // lblUploadLimit
            // 
            this.lblUploadLimit.AutoSize = true;
            this.lblUploadLimit.Location = new System.Drawing.Point(16, 24);
            this.lblUploadLimit.Name = "lblUploadLimit";
            this.lblUploadLimit.Size = new System.Drawing.Size(128, 13);
            this.lblUploadLimit.TabIndex = 10;
            this.lblUploadLimit.Text = "Simultaneous upload limit:";
            // 
            // lblBufferSize
            // 
            this.lblBufferSize.AutoSize = true;
            this.lblBufferSize.Location = new System.Drawing.Point(16, 56);
            this.lblBufferSize.Name = "lblBufferSize";
            this.lblBufferSize.Size = new System.Drawing.Size(59, 13);
            this.lblBufferSize.TabIndex = 13;
            this.lblBufferSize.Text = "Buffer size:";
            // 
            // lblBufferSizeInfo
            // 
            this.lblBufferSizeInfo.AutoSize = true;
            this.lblBufferSizeInfo.Location = new System.Drawing.Point(152, 56);
            this.lblBufferSizeInfo.Name = "lblBufferSizeInfo";
            this.lblBufferSizeInfo.Size = new System.Drawing.Size(23, 13);
            this.lblBufferSizeInfo.TabIndex = 15;
            this.lblBufferSizeInfo.Text = "KiB";
            // 
            // cbBufferSize
            // 
            this.cbBufferSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBufferSize.FormattingEnabled = true;
            this.cbBufferSize.Location = new System.Drawing.Point(80, 52);
            this.cbBufferSize.Name = "cbBufferSize";
            this.cbBufferSize.Size = new System.Drawing.Size(64, 21);
            this.cbBufferSize.TabIndex = 14;
            this.cbBufferSize.SelectedIndexChanged += new System.EventHandler(this.cbBufferSize_SelectedIndexChanged);
            // 
            // tpHotkeys
            // 
            this.tpHotkeys.Controls.Add(this.panelHotkeys);
            this.tpHotkeys.Location = new System.Drawing.Point(4, 22);
            this.tpHotkeys.Name = "tpHotkeys";
            this.tpHotkeys.Padding = new System.Windows.Forms.Padding(3);
            this.tpHotkeys.Size = new System.Drawing.Size(543, 488);
            this.tpHotkeys.TabIndex = 7;
            this.tpHotkeys.Text = "Hotkeys";
            this.tpHotkeys.UseVisualStyleBackColor = true;
            // 
            // panelHotkeys
            // 
            this.panelHotkeys.Controls.Add(this.hmHotkeys);
            this.panelHotkeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHotkeys.Location = new System.Drawing.Point(3, 3);
            this.panelHotkeys.Name = "panelHotkeys";
            this.panelHotkeys.Size = new System.Drawing.Size(550, 528);
            this.panelHotkeys.TabIndex = 0;
            // 
            // hmHotkeys
            // 
            this.hmHotkeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmHotkeys.Location = new System.Drawing.Point(0, 0);
            this.hmHotkeys.Name = "hmHotkeys";
            this.hmHotkeys.Size = new System.Drawing.Size(550, 528);
            this.hmHotkeys.TabIndex = 1;
            // 
            // tpImageQuality
            // 
            this.tpImageQuality.Controls.Add(this.panelImageQuality);
            this.tpImageQuality.Location = new System.Drawing.Point(4, 22);
            this.tpImageQuality.Name = "tpImageQuality";
            this.tpImageQuality.Padding = new System.Windows.Forms.Padding(3);
            this.tpImageQuality.Size = new System.Drawing.Size(543, 488);
            this.tpImageQuality.TabIndex = 8;
            this.tpImageQuality.Text = "Quality";
            this.tpImageQuality.UseVisualStyleBackColor = true;
            // 
            // panelImageQuality
            // 
            this.panelImageQuality.Controls.Add(this.cbImageUseSmoothScaling);
            this.panelImageQuality.Controls.Add(this.cbImageKeepAspectRatio);
            this.panelImageQuality.Controls.Add(this.cbImageAutoResize);
            this.panelImageQuality.Controls.Add(this.gbImageScaleSettings);
            this.panelImageQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageQuality.Location = new System.Drawing.Point(3, 3);
            this.panelImageQuality.Name = "panelImageQuality";
            this.panelImageQuality.Size = new System.Drawing.Size(537, 482);
            this.panelImageQuality.TabIndex = 0;
            // 
            // cbImageUseSmoothScaling
            // 
            this.cbImageUseSmoothScaling.AutoSize = true;
            this.cbImageUseSmoothScaling.Location = new System.Drawing.Point(16, 64);
            this.cbImageUseSmoothScaling.Name = "cbImageUseSmoothScaling";
            this.cbImageUseSmoothScaling.Size = new System.Drawing.Size(183, 17);
            this.cbImageUseSmoothScaling.TabIndex = 6;
            this.cbImageUseSmoothScaling.Text = "Use smooth scaling (Anti aliasing)";
            this.cbImageUseSmoothScaling.UseVisualStyleBackColor = true;
            this.cbImageUseSmoothScaling.CheckedChanged += new System.EventHandler(this.cbImageUseSmoothScaling_CheckedChanged);
            // 
            // cbImageKeepAspectRatio
            // 
            this.cbImageKeepAspectRatio.AutoSize = true;
            this.cbImageKeepAspectRatio.Location = new System.Drawing.Point(16, 40);
            this.cbImageKeepAspectRatio.Name = "cbImageKeepAspectRatio";
            this.cbImageKeepAspectRatio.Size = new System.Drawing.Size(109, 17);
            this.cbImageKeepAspectRatio.TabIndex = 5;
            this.cbImageKeepAspectRatio.Text = "Keep aspect ratio";
            this.cbImageKeepAspectRatio.UseVisualStyleBackColor = true;
            this.cbImageKeepAspectRatio.CheckedChanged += new System.EventHandler(this.cbImageKeepAspectRatio_CheckedChanged);
            // 
            // cbImageAutoResize
            // 
            this.cbImageAutoResize.AutoSize = true;
            this.cbImageAutoResize.Location = new System.Drawing.Point(16, 16);
            this.cbImageAutoResize.Name = "cbImageAutoResize";
            this.cbImageAutoResize.Size = new System.Drawing.Size(149, 17);
            this.cbImageAutoResize.TabIndex = 4;
            this.cbImageAutoResize.Text = "Automatically resize image";
            this.cbImageAutoResize.UseVisualStyleBackColor = true;
            this.cbImageAutoResize.CheckedChanged += new System.EventHandler(this.cbImageAutoResize_CheckedChanged);
            // 
            // gbImageScaleSettings
            // 
            this.gbImageScaleSettings.Controls.Add(this.rbImageScaleTypePercentage);
            this.gbImageScaleSettings.Controls.Add(this.lblImageScaleToHeight2);
            this.gbImageScaleSettings.Controls.Add(this.rbImageScaleTypeToWidth);
            this.gbImageScaleSettings.Controls.Add(this.lblImageScaleSpecificWidth2);
            this.gbImageScaleSettings.Controls.Add(this.rbImageScaleTypeToHeight);
            this.gbImageScaleSettings.Controls.Add(this.lblImageScaleSpecificHeight2);
            this.gbImageScaleSettings.Controls.Add(this.rbImageScaleTypeSpecific);
            this.gbImageScaleSettings.Controls.Add(this.lblImageScaleToWidth2);
            this.gbImageScaleSettings.Controls.Add(this.lblImageScalePercentageWidth);
            this.gbImageScaleSettings.Controls.Add(this.lblImageScalePercentageHeight2);
            this.gbImageScaleSettings.Controls.Add(this.nudImageScalePercentageWidth);
            this.gbImageScaleSettings.Controls.Add(this.lblImageScalePercentageWidth2);
            this.gbImageScaleSettings.Controls.Add(this.lblImageScalePercentageHeight);
            this.gbImageScaleSettings.Controls.Add(this.nudImageScaleToHeight);
            this.gbImageScaleSettings.Controls.Add(this.nudImageScalePercentageHeight);
            this.gbImageScaleSettings.Controls.Add(this.nudImageScaleToWidth);
            this.gbImageScaleSettings.Controls.Add(this.lblImageScaleToWidth);
            this.gbImageScaleSettings.Controls.Add(this.nudImageScaleSpecificHeight);
            this.gbImageScaleSettings.Controls.Add(this.lblImageScaleToHeight);
            this.gbImageScaleSettings.Controls.Add(this.lblImageScaleSpecificHeight);
            this.gbImageScaleSettings.Controls.Add(this.lblImageScaleSpecificWidth);
            this.gbImageScaleSettings.Controls.Add(this.nudImageScaleSpecificWidth);
            this.gbImageScaleSettings.Location = new System.Drawing.Point(16, 104);
            this.gbImageScaleSettings.Name = "gbImageScaleSettings";
            this.gbImageScaleSettings.Size = new System.Drawing.Size(200, 272);
            this.gbImageScaleSettings.TabIndex = 7;
            this.gbImageScaleSettings.TabStop = false;
            this.gbImageScaleSettings.Text = "Scale settings";
            // 
            // rbImageScaleTypePercentage
            // 
            this.rbImageScaleTypePercentage.AutoSize = true;
            this.rbImageScaleTypePercentage.Location = new System.Drawing.Point(16, 24);
            this.rbImageScaleTypePercentage.Name = "rbImageScaleTypePercentage";
            this.rbImageScaleTypePercentage.Size = new System.Drawing.Size(123, 17);
            this.rbImageScaleTypePercentage.TabIndex = 0;
            this.rbImageScaleTypePercentage.TabStop = true;
            this.rbImageScaleTypePercentage.Text = "Scale by percentage";
            this.rbImageScaleTypePercentage.UseVisualStyleBackColor = true;
            this.rbImageScaleTypePercentage.CheckedChanged += new System.EventHandler(this.rbImageScaleTypePercentage_CheckedChanged);
            // 
            // lblImageScaleToHeight2
            // 
            this.lblImageScaleToHeight2.AutoSize = true;
            this.lblImageScaleToHeight2.Location = new System.Drawing.Point(144, 172);
            this.lblImageScaleToHeight2.Name = "lblImageScaleToHeight2";
            this.lblImageScaleToHeight2.Size = new System.Drawing.Size(33, 13);
            this.lblImageScaleToHeight2.TabIndex = 14;
            this.lblImageScaleToHeight2.Text = "pixels";
            // 
            // rbImageScaleTypeToWidth
            // 
            this.rbImageScaleTypeToWidth.AutoSize = true;
            this.rbImageScaleTypeToWidth.Location = new System.Drawing.Point(16, 96);
            this.rbImageScaleTypeToWidth.Name = "rbImageScaleTypeToWidth";
            this.rbImageScaleTypeToWidth.Size = new System.Drawing.Size(92, 17);
            this.rbImageScaleTypeToWidth.TabIndex = 7;
            this.rbImageScaleTypeToWidth.TabStop = true;
            this.rbImageScaleTypeToWidth.Text = "Scale to width";
            this.rbImageScaleTypeToWidth.UseVisualStyleBackColor = true;
            this.rbImageScaleTypeToWidth.CheckedChanged += new System.EventHandler(this.rbImageScaleTypeToWidth_CheckedChanged);
            // 
            // lblImageScaleSpecificWidth2
            // 
            this.lblImageScaleSpecificWidth2.AutoSize = true;
            this.lblImageScaleSpecificWidth2.Location = new System.Drawing.Point(144, 220);
            this.lblImageScaleSpecificWidth2.Name = "lblImageScaleSpecificWidth2";
            this.lblImageScaleSpecificWidth2.Size = new System.Drawing.Size(33, 13);
            this.lblImageScaleSpecificWidth2.TabIndex = 18;
            this.lblImageScaleSpecificWidth2.Text = "pixels";
            // 
            // rbImageScaleTypeToHeight
            // 
            this.rbImageScaleTypeToHeight.AutoSize = true;
            this.rbImageScaleTypeToHeight.Location = new System.Drawing.Point(16, 144);
            this.rbImageScaleTypeToHeight.Name = "rbImageScaleTypeToHeight";
            this.rbImageScaleTypeToHeight.Size = new System.Drawing.Size(96, 17);
            this.rbImageScaleTypeToHeight.TabIndex = 11;
            this.rbImageScaleTypeToHeight.TabStop = true;
            this.rbImageScaleTypeToHeight.Text = "Scale to height";
            this.rbImageScaleTypeToHeight.UseVisualStyleBackColor = true;
            this.rbImageScaleTypeToHeight.CheckedChanged += new System.EventHandler(this.rbImageScaleTypeToHeight_CheckedChanged);
            // 
            // lblImageScaleSpecificHeight2
            // 
            this.lblImageScaleSpecificHeight2.AutoSize = true;
            this.lblImageScaleSpecificHeight2.Location = new System.Drawing.Point(144, 244);
            this.lblImageScaleSpecificHeight2.Name = "lblImageScaleSpecificHeight2";
            this.lblImageScaleSpecificHeight2.Size = new System.Drawing.Size(33, 13);
            this.lblImageScaleSpecificHeight2.TabIndex = 21;
            this.lblImageScaleSpecificHeight2.Text = "pixels";
            // 
            // rbImageScaleTypeSpecific
            // 
            this.rbImageScaleTypeSpecific.AutoSize = true;
            this.rbImageScaleTypeSpecific.Location = new System.Drawing.Point(16, 192);
            this.rbImageScaleTypeSpecific.Name = "rbImageScaleTypeSpecific";
            this.rbImageScaleTypeSpecific.Size = new System.Drawing.Size(84, 17);
            this.rbImageScaleTypeSpecific.TabIndex = 15;
            this.rbImageScaleTypeSpecific.TabStop = true;
            this.rbImageScaleTypeSpecific.Text = "Specific size";
            this.rbImageScaleTypeSpecific.UseVisualStyleBackColor = true;
            this.rbImageScaleTypeSpecific.CheckedChanged += new System.EventHandler(this.rbImageScaleTypeSpecific_CheckedChanged);
            // 
            // lblImageScaleToWidth2
            // 
            this.lblImageScaleToWidth2.AutoSize = true;
            this.lblImageScaleToWidth2.Location = new System.Drawing.Point(144, 124);
            this.lblImageScaleToWidth2.Name = "lblImageScaleToWidth2";
            this.lblImageScaleToWidth2.Size = new System.Drawing.Size(33, 13);
            this.lblImageScaleToWidth2.TabIndex = 10;
            this.lblImageScaleToWidth2.Text = "pixels";
            // 
            // lblImageScalePercentageWidth
            // 
            this.lblImageScalePercentageWidth.AutoSize = true;
            this.lblImageScalePercentageWidth.Location = new System.Drawing.Point(32, 52);
            this.lblImageScalePercentageWidth.Name = "lblImageScalePercentageWidth";
            this.lblImageScalePercentageWidth.Size = new System.Drawing.Size(38, 13);
            this.lblImageScalePercentageWidth.TabIndex = 1;
            this.lblImageScalePercentageWidth.Text = "Width:";
            // 
            // lblImageScalePercentageHeight2
            // 
            this.lblImageScalePercentageHeight2.AutoSize = true;
            this.lblImageScalePercentageHeight2.Location = new System.Drawing.Point(144, 76);
            this.lblImageScalePercentageHeight2.Name = "lblImageScalePercentageHeight2";
            this.lblImageScalePercentageHeight2.Size = new System.Drawing.Size(15, 13);
            this.lblImageScalePercentageHeight2.TabIndex = 6;
            this.lblImageScalePercentageHeight2.Text = "%";
            // 
            // nudImageScalePercentageWidth
            // 
            this.nudImageScalePercentageWidth.Location = new System.Drawing.Point(80, 48);
            this.nudImageScalePercentageWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudImageScalePercentageWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudImageScalePercentageWidth.Name = "nudImageScalePercentageWidth";
            this.nudImageScalePercentageWidth.Size = new System.Drawing.Size(56, 20);
            this.nudImageScalePercentageWidth.TabIndex = 2;
            this.nudImageScalePercentageWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudImageScalePercentageWidth.ValueChanged += new System.EventHandler(this.nudImageScalePercentageWidth_ValueChanged);
            // 
            // lblImageScalePercentageWidth2
            // 
            this.lblImageScalePercentageWidth2.AutoSize = true;
            this.lblImageScalePercentageWidth2.Location = new System.Drawing.Point(144, 52);
            this.lblImageScalePercentageWidth2.Name = "lblImageScalePercentageWidth2";
            this.lblImageScalePercentageWidth2.Size = new System.Drawing.Size(15, 13);
            this.lblImageScalePercentageWidth2.TabIndex = 3;
            this.lblImageScalePercentageWidth2.Text = "%";
            // 
            // lblImageScalePercentageHeight
            // 
            this.lblImageScalePercentageHeight.AutoSize = true;
            this.lblImageScalePercentageHeight.Location = new System.Drawing.Point(32, 76);
            this.lblImageScalePercentageHeight.Name = "lblImageScalePercentageHeight";
            this.lblImageScalePercentageHeight.Size = new System.Drawing.Size(41, 13);
            this.lblImageScalePercentageHeight.TabIndex = 4;
            this.lblImageScalePercentageHeight.Text = "Height:";
            // 
            // nudImageScaleToHeight
            // 
            this.nudImageScaleToHeight.Location = new System.Drawing.Point(80, 168);
            this.nudImageScaleToHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudImageScaleToHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudImageScaleToHeight.Name = "nudImageScaleToHeight";
            this.nudImageScaleToHeight.Size = new System.Drawing.Size(56, 20);
            this.nudImageScaleToHeight.TabIndex = 13;
            this.nudImageScaleToHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudImageScaleToHeight.ValueChanged += new System.EventHandler(this.nudImageScaleToHeight_ValueChanged);
            // 
            // nudImageScalePercentageHeight
            // 
            this.nudImageScalePercentageHeight.Location = new System.Drawing.Point(80, 72);
            this.nudImageScalePercentageHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudImageScalePercentageHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudImageScalePercentageHeight.Name = "nudImageScalePercentageHeight";
            this.nudImageScalePercentageHeight.Size = new System.Drawing.Size(56, 20);
            this.nudImageScalePercentageHeight.TabIndex = 5;
            this.nudImageScalePercentageHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudImageScalePercentageHeight.ValueChanged += new System.EventHandler(this.nudImageScalePercentageHeight_ValueChanged);
            // 
            // nudImageScaleToWidth
            // 
            this.nudImageScaleToWidth.Location = new System.Drawing.Point(80, 120);
            this.nudImageScaleToWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudImageScaleToWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudImageScaleToWidth.Name = "nudImageScaleToWidth";
            this.nudImageScaleToWidth.Size = new System.Drawing.Size(56, 20);
            this.nudImageScaleToWidth.TabIndex = 9;
            this.nudImageScaleToWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudImageScaleToWidth.ValueChanged += new System.EventHandler(this.nudImageScaleToWidth_ValueChanged);
            // 
            // lblImageScaleToWidth
            // 
            this.lblImageScaleToWidth.AutoSize = true;
            this.lblImageScaleToWidth.Location = new System.Drawing.Point(32, 124);
            this.lblImageScaleToWidth.Name = "lblImageScaleToWidth";
            this.lblImageScaleToWidth.Size = new System.Drawing.Size(38, 13);
            this.lblImageScaleToWidth.TabIndex = 8;
            this.lblImageScaleToWidth.Text = "Width:";
            // 
            // nudImageScaleSpecificHeight
            // 
            this.nudImageScaleSpecificHeight.Location = new System.Drawing.Point(80, 240);
            this.nudImageScaleSpecificHeight.Name = "nudImageScaleSpecificHeight";
            this.nudImageScaleSpecificHeight.Size = new System.Drawing.Size(56, 20);
            this.nudImageScaleSpecificHeight.TabIndex = 20;
            this.nudImageScaleSpecificHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudImageScaleSpecificHeight.ValueChanged += new System.EventHandler(this.nudImageScaleSpecificHeight_ValueChanged);
            // 
            // lblImageScaleToHeight
            // 
            this.lblImageScaleToHeight.AutoSize = true;
            this.lblImageScaleToHeight.Location = new System.Drawing.Point(32, 172);
            this.lblImageScaleToHeight.Name = "lblImageScaleToHeight";
            this.lblImageScaleToHeight.Size = new System.Drawing.Size(41, 13);
            this.lblImageScaleToHeight.TabIndex = 12;
            this.lblImageScaleToHeight.Text = "Height:";
            // 
            // lblImageScaleSpecificHeight
            // 
            this.lblImageScaleSpecificHeight.AutoSize = true;
            this.lblImageScaleSpecificHeight.Location = new System.Drawing.Point(32, 244);
            this.lblImageScaleSpecificHeight.Name = "lblImageScaleSpecificHeight";
            this.lblImageScaleSpecificHeight.Size = new System.Drawing.Size(41, 13);
            this.lblImageScaleSpecificHeight.TabIndex = 19;
            this.lblImageScaleSpecificHeight.Text = "Height:";
            // 
            // lblImageScaleSpecificWidth
            // 
            this.lblImageScaleSpecificWidth.AutoSize = true;
            this.lblImageScaleSpecificWidth.Location = new System.Drawing.Point(32, 220);
            this.lblImageScaleSpecificWidth.Name = "lblImageScaleSpecificWidth";
            this.lblImageScaleSpecificWidth.Size = new System.Drawing.Size(38, 13);
            this.lblImageScaleSpecificWidth.TabIndex = 16;
            this.lblImageScaleSpecificWidth.Text = "Width:";
            // 
            // nudImageScaleSpecificWidth
            // 
            this.nudImageScaleSpecificWidth.Location = new System.Drawing.Point(80, 216);
            this.nudImageScaleSpecificWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudImageScaleSpecificWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudImageScaleSpecificWidth.Name = "nudImageScaleSpecificWidth";
            this.nudImageScaleSpecificWidth.Size = new System.Drawing.Size(56, 20);
            this.nudImageScaleSpecificWidth.TabIndex = 17;
            this.nudImageScaleSpecificWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudImageScaleSpecificWidth.ValueChanged += new System.EventHandler(this.nudImageScaleSpecificWidth_ValueChanged);
            // 
            // tpImageResize
            // 
            this.tpImageResize.Controls.Add(this.panelImageResize);
            this.tpImageResize.Location = new System.Drawing.Point(4, 22);
            this.tpImageResize.Name = "tpImageResize";
            this.tpImageResize.Padding = new System.Windows.Forms.Padding(3);
            this.tpImageResize.Size = new System.Drawing.Size(543, 488);
            this.tpImageResize.TabIndex = 9;
            this.tpImageResize.Text = "Resize";
            this.tpImageResize.UseVisualStyleBackColor = true;
            // 
            // panelImageResize
            // 
            this.panelImageResize.Controls.Add(this.lblImageFormat);
            this.panelImageResize.Controls.Add(this.lblUseImageFormat2AfterHint);
            this.panelImageResize.Controls.Add(this.cbImageFormat);
            this.panelImageResize.Controls.Add(this.lblImageJPEGQualityHint);
            this.panelImageResize.Controls.Add(this.lblImageJPEGQuality);
            this.panelImageResize.Controls.Add(this.cbImageGIFQuality);
            this.panelImageResize.Controls.Add(this.lblImageGIFQuality);
            this.panelImageResize.Controls.Add(this.cbImageFormat2);
            this.panelImageResize.Controls.Add(this.nudImageJPEGQuality);
            this.panelImageResize.Controls.Add(this.lblImageFormat2);
            this.panelImageResize.Controls.Add(this.nudUseImageFormat2After);
            this.panelImageResize.Controls.Add(this.lblUseImageFormat2After);
            this.panelImageResize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageResize.Location = new System.Drawing.Point(3, 3);
            this.panelImageResize.Name = "panelImageResize";
            this.panelImageResize.Size = new System.Drawing.Size(537, 482);
            this.panelImageResize.TabIndex = 0;
            // 
            // lblImageFormat
            // 
            this.lblImageFormat.AutoSize = true;
            this.lblImageFormat.Location = new System.Drawing.Point(16, 20);
            this.lblImageFormat.Name = "lblImageFormat";
            this.lblImageFormat.Size = new System.Drawing.Size(71, 13);
            this.lblImageFormat.TabIndex = 12;
            this.lblImageFormat.Text = "Image format:";
            // 
            // lblUseImageFormat2AfterHint
            // 
            this.lblUseImageFormat2AfterHint.AutoSize = true;
            this.lblUseImageFormat2AfterHint.Location = new System.Drawing.Point(288, 116);
            this.lblUseImageFormat2AfterHint.Name = "lblUseImageFormat2AfterHint";
            this.lblUseImageFormat2AfterHint.Size = new System.Drawing.Size(124, 13);
            this.lblUseImageFormat2AfterHint.TabIndex = 21;
            this.lblUseImageFormat2AfterHint.Text = "KiB  0 - 5000 (0 disables)";
            // 
            // cbImageFormat
            // 
            this.cbImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImageFormat.FormattingEnabled = true;
            this.cbImageFormat.Items.AddRange(new object[] {
            "PNG",
            "JPEG",
            "GIF",
            "BMP",
            "TIFF"});
            this.cbImageFormat.Location = new System.Drawing.Point(104, 16);
            this.cbImageFormat.Name = "cbImageFormat";
            this.cbImageFormat.Size = new System.Drawing.Size(56, 21);
            this.cbImageFormat.TabIndex = 13;
            this.cbImageFormat.SelectedIndexChanged += new System.EventHandler(this.cbImageFormat_SelectedIndexChanged);
            // 
            // lblImageJPEGQualityHint
            // 
            this.lblImageJPEGQualityHint.AutoSize = true;
            this.lblImageJPEGQualityHint.Location = new System.Drawing.Point(168, 52);
            this.lblImageJPEGQualityHint.Name = "lblImageJPEGQualityHint";
            this.lblImageJPEGQualityHint.Size = new System.Drawing.Size(40, 13);
            this.lblImageJPEGQualityHint.TabIndex = 16;
            this.lblImageJPEGQualityHint.Text = "0 - 100";
            // 
            // lblImageJPEGQuality
            // 
            this.lblImageJPEGQuality.AutoSize = true;
            this.lblImageJPEGQuality.Location = new System.Drawing.Point(16, 52);
            this.lblImageJPEGQuality.Name = "lblImageJPEGQuality";
            this.lblImageJPEGQuality.Size = new System.Drawing.Size(70, 13);
            this.lblImageJPEGQuality.TabIndex = 14;
            this.lblImageJPEGQuality.Text = "JPEG quality:";
            // 
            // cbImageGIFQuality
            // 
            this.cbImageGIFQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImageGIFQuality.FormattingEnabled = true;
            this.cbImageGIFQuality.Items.AddRange(new object[] {
            "Default (Fast)",
            "256 colors (8 bit)",
            "16 colors (4 bit)",
            "Grayscale"});
            this.cbImageGIFQuality.Location = new System.Drawing.Point(104, 80);
            this.cbImageGIFQuality.Name = "cbImageGIFQuality";
            this.cbImageGIFQuality.Size = new System.Drawing.Size(120, 21);
            this.cbImageGIFQuality.TabIndex = 18;
            this.cbImageGIFQuality.SelectedIndexChanged += new System.EventHandler(this.cbImageGIFQuality_SelectedIndexChanged);
            // 
            // lblImageGIFQuality
            // 
            this.lblImageGIFQuality.AutoSize = true;
            this.lblImageGIFQuality.Location = new System.Drawing.Point(16, 84);
            this.lblImageGIFQuality.Name = "lblImageGIFQuality";
            this.lblImageGIFQuality.Size = new System.Drawing.Size(60, 13);
            this.lblImageGIFQuality.TabIndex = 17;
            this.lblImageGIFQuality.Text = "GIF quality:";
            // 
            // cbImageFormat2
            // 
            this.cbImageFormat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImageFormat2.FormattingEnabled = true;
            this.cbImageFormat2.Items.AddRange(new object[] {
            "PNG",
            "JPEG",
            "GIF",
            "BMP",
            "TIFF"});
            this.cbImageFormat2.Location = new System.Drawing.Point(104, 144);
            this.cbImageFormat2.Name = "cbImageFormat2";
            this.cbImageFormat2.Size = new System.Drawing.Size(56, 21);
            this.cbImageFormat2.TabIndex = 23;
            this.cbImageFormat2.SelectedIndexChanged += new System.EventHandler(this.cbImageFormat2_SelectedIndexChanged);
            // 
            // nudImageJPEGQuality
            // 
            this.nudImageJPEGQuality.Location = new System.Drawing.Point(104, 48);
            this.nudImageJPEGQuality.Name = "nudImageJPEGQuality";
            this.nudImageJPEGQuality.Size = new System.Drawing.Size(56, 20);
            this.nudImageJPEGQuality.TabIndex = 15;
            this.nudImageJPEGQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudImageJPEGQuality.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudImageJPEGQuality.ValueChanged += new System.EventHandler(this.nudImageJPEGQuality_ValueChanged);
            // 
            // lblImageFormat2
            // 
            this.lblImageFormat2.AutoSize = true;
            this.lblImageFormat2.Location = new System.Drawing.Point(16, 148);
            this.lblImageFormat2.Name = "lblImageFormat2";
            this.lblImageFormat2.Size = new System.Drawing.Size(80, 13);
            this.lblImageFormat2.TabIndex = 22;
            this.lblImageFormat2.Text = "Image format 2:";
            // 
            // nudUseImageFormat2After
            // 
            this.nudUseImageFormat2After.Location = new System.Drawing.Point(224, 112);
            this.nudUseImageFormat2After.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudUseImageFormat2After.Name = "nudUseImageFormat2After";
            this.nudUseImageFormat2After.Size = new System.Drawing.Size(56, 20);
            this.nudUseImageFormat2After.TabIndex = 20;
            this.nudUseImageFormat2After.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudUseImageFormat2After.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudUseImageFormat2After.ValueChanged += new System.EventHandler(this.nudUseImageFormat2After_ValueChanged);
            // 
            // lblUseImageFormat2After
            // 
            this.lblUseImageFormat2After.AutoSize = true;
            this.lblUseImageFormat2After.Location = new System.Drawing.Point(16, 116);
            this.lblUseImageFormat2After.Name = "lblUseImageFormat2After";
            this.lblUseImageFormat2After.Size = new System.Drawing.Size(198, 13);
            this.lblUseImageFormat2After.TabIndex = 19;
            this.lblUseImageFormat2After.Text = "Image size limit for use \"Image format 2\":";
            // 
            // tpPaths
            // 
            this.tpPaths.Controls.Add(this.panelPaths);
            this.tpPaths.Location = new System.Drawing.Point(4, 22);
            this.tpPaths.Name = "tpPaths";
            this.tpPaths.Padding = new System.Windows.Forms.Padding(3);
            this.tpPaths.Size = new System.Drawing.Size(543, 520);
            this.tpPaths.TabIndex = 10;
            this.tpPaths.Text = "Paths";
            this.tpPaths.UseVisualStyleBackColor = true;
            // 
            // panelPaths
            // 
            this.panelPaths.AutoScroll = true;
            this.panelPaths.Controls.Add(this.gbPathRoot);
            this.panelPaths.Controls.Add(this.gbScreenshots);
            this.panelPaths.Controls.Add(this.gbUploadersConfig);
            this.panelPaths.Controls.Add(this.gbHistory);
            this.panelPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaths.Location = new System.Drawing.Point(3, 3);
            this.panelPaths.Name = "panelPaths";
            this.panelPaths.Size = new System.Drawing.Size(537, 514);
            this.panelPaths.TabIndex = 0;
            // 
            // gbPathRoot
            // 
            this.gbPathRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPathRoot.Controls.Add(this.lblOpenZUploaderPath);
            this.gbPathRoot.Controls.Add(this.btnOpenZUploaderPath);
            this.gbPathRoot.Location = new System.Drawing.Point(8, 360);
            this.gbPathRoot.Name = "gbPathRoot";
            this.gbPathRoot.Size = new System.Drawing.Size(520, 88);
            this.gbPathRoot.TabIndex = 13;
            this.gbPathRoot.TabStop = false;
            this.gbPathRoot.Text = "Root";
            // 
            // lblOpenZUploaderPath
            // 
            this.lblOpenZUploaderPath.AutoSize = true;
            this.lblOpenZUploaderPath.Location = new System.Drawing.Point(16, 56);
            this.lblOpenZUploaderPath.Name = "lblOpenZUploaderPath";
            this.lblOpenZUploaderPath.Size = new System.Drawing.Size(257, 13);
            this.lblOpenZUploaderPath.TabIndex = 11;
            this.lblOpenZUploaderPath.Text = "This folder has settings, history database and log files";
            // 
            // btnOpenZUploaderPath
            // 
            this.btnOpenZUploaderPath.Location = new System.Drawing.Point(16, 24);
            this.btnOpenZUploaderPath.Name = "btnOpenZUploaderPath";
            this.btnOpenZUploaderPath.Size = new System.Drawing.Size(176, 23);
            this.btnOpenZUploaderPath.TabIndex = 10;
            this.btnOpenZUploaderPath.Text = "Open ShareX personal folder";
            this.btnOpenZUploaderPath.UseVisualStyleBackColor = true;
            this.btnOpenZUploaderPath.Click += new System.EventHandler(this.btnOpenPersonalPath_Click);
            // 
            // gbScreenshots
            // 
            this.gbScreenshots.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbScreenshots.Controls.Add(this.txtSaveImageSubFolderPatternPreview);
            this.gbScreenshots.Controls.Add(this.lblSaveImageSubFolderPattern);
            this.gbScreenshots.Controls.Add(this.txtSaveImageSubFolderPattern);
            this.gbScreenshots.Controls.Add(this.btnBrowseScreenshotsDir);
            this.gbScreenshots.Controls.Add(this.txtScreenshotsPath);
            this.gbScreenshots.Location = new System.Drawing.Point(8, 8);
            this.gbScreenshots.Name = "gbScreenshots";
            this.gbScreenshots.Size = new System.Drawing.Size(520, 88);
            this.gbScreenshots.TabIndex = 12;
            this.gbScreenshots.TabStop = false;
            this.gbScreenshots.Text = "Screenshots";
            // 
            // txtSaveImageSubFolderPatternPreview
            // 
            this.txtSaveImageSubFolderPatternPreview.Location = new System.Drawing.Point(248, 53);
            this.txtSaveImageSubFolderPatternPreview.Name = "txtSaveImageSubFolderPatternPreview";
            this.txtSaveImageSubFolderPatternPreview.ReadOnly = true;
            this.txtSaveImageSubFolderPatternPreview.Size = new System.Drawing.Size(120, 20);
            this.txtSaveImageSubFolderPatternPreview.TabIndex = 6;
            // 
            // lblSaveImageSubFolderPattern
            // 
            this.lblSaveImageSubFolderPattern.AutoSize = true;
            this.lblSaveImageSubFolderPattern.Location = new System.Drawing.Point(16, 56);
            this.lblSaveImageSubFolderPattern.Name = "lblSaveImageSubFolderPattern";
            this.lblSaveImageSubFolderPattern.Size = new System.Drawing.Size(94, 13);
            this.lblSaveImageSubFolderPattern.TabIndex = 3;
            this.lblSaveImageSubFolderPattern.Text = "Sub folder pattern:";
            // 
            // txtSaveImageSubFolderPattern
            // 
            this.txtSaveImageSubFolderPattern.Location = new System.Drawing.Point(120, 52);
            this.txtSaveImageSubFolderPattern.Name = "txtSaveImageSubFolderPattern";
            this.txtSaveImageSubFolderPattern.Size = new System.Drawing.Size(120, 20);
            this.txtSaveImageSubFolderPattern.TabIndex = 4;
            this.txtSaveImageSubFolderPattern.TextChanged += new System.EventHandler(this.txtSaveImageSubFolderPattern_TextChanged);
            // 
            // btnBrowseScreenshotsDir
            // 
            this.btnBrowseScreenshotsDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseScreenshotsDir.AutoSize = true;
            this.btnBrowseScreenshotsDir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseScreenshotsDir.Location = new System.Drawing.Point(448, 51);
            this.btnBrowseScreenshotsDir.Name = "btnBrowseScreenshotsDir";
            this.btnBrowseScreenshotsDir.Size = new System.Drawing.Size(61, 23);
            this.btnBrowseScreenshotsDir.TabIndex = 7;
            this.btnBrowseScreenshotsDir.Text = "&Browse...";
            this.btnBrowseScreenshotsDir.UseVisualStyleBackColor = true;
            this.btnBrowseScreenshotsDir.Click += new System.EventHandler(this.btnBrowseScreenshotsDir_Click);
            // 
            // txtScreenshotsPath
            // 
            this.txtScreenshotsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScreenshotsPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtScreenshotsPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtScreenshotsPath.Location = new System.Drawing.Point(16, 24);
            this.txtScreenshotsPath.Name = "txtScreenshotsPath";
            this.txtScreenshotsPath.Size = new System.Drawing.Size(488, 20);
            this.txtScreenshotsPath.TabIndex = 5;
            // 
            // gbUploadersConfig
            // 
            this.gbUploadersConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUploadersConfig.Controls.Add(this.btnLoadUploadersConfig);
            this.gbUploadersConfig.Controls.Add(this.btnBrowseCustomUploadersConfigPath);
            this.gbUploadersConfig.Controls.Add(this.txtCustomUploadersConfigPath);
            this.gbUploadersConfig.Controls.Add(this.cbUseCustomUploadersConfigPath);
            this.gbUploadersConfig.Location = new System.Drawing.Point(8, 112);
            this.gbUploadersConfig.Name = "gbUploadersConfig";
            this.gbUploadersConfig.Size = new System.Drawing.Size(520, 80);
            this.gbUploadersConfig.TabIndex = 1;
            this.gbUploadersConfig.TabStop = false;
            this.gbUploadersConfig.Text = "Uploaders Config";
            // 
            // btnLoadUploadersConfig
            // 
            this.btnLoadUploadersConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadUploadersConfig.AutoSize = true;
            this.btnLoadUploadersConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadUploadersConfig.Location = new System.Drawing.Point(400, 45);
            this.btnLoadUploadersConfig.Name = "btnLoadUploadersConfig";
            this.btnLoadUploadersConfig.Size = new System.Drawing.Size(41, 23);
            this.btnLoadUploadersConfig.TabIndex = 7;
            this.btnLoadUploadersConfig.Text = "Load";
            this.btnLoadUploadersConfig.UseVisualStyleBackColor = true;
            this.btnLoadUploadersConfig.Click += new System.EventHandler(this.btnLoadUploadersConfig_Click);
            // 
            // btnBrowseCustomUploadersConfigPath
            // 
            this.btnBrowseCustomUploadersConfigPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseCustomUploadersConfigPath.AutoSize = true;
            this.btnBrowseCustomUploadersConfigPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseCustomUploadersConfigPath.Location = new System.Drawing.Point(448, 45);
            this.btnBrowseCustomUploadersConfigPath.Name = "btnBrowseCustomUploadersConfigPath";
            this.btnBrowseCustomUploadersConfigPath.Size = new System.Drawing.Size(61, 23);
            this.btnBrowseCustomUploadersConfigPath.TabIndex = 6;
            this.btnBrowseCustomUploadersConfigPath.Text = "Browse...";
            this.btnBrowseCustomUploadersConfigPath.UseVisualStyleBackColor = true;
            this.btnBrowseCustomUploadersConfigPath.Click += new System.EventHandler(this.btnBrowseCustomUploadersConfigPath_Click);
            // 
            // txtCustomUploadersConfigPath
            // 
            this.txtCustomUploadersConfigPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomUploadersConfigPath.Location = new System.Drawing.Point(16, 48);
            this.txtCustomUploadersConfigPath.Name = "txtCustomUploadersConfigPath";
            this.txtCustomUploadersConfigPath.Size = new System.Drawing.Size(376, 20);
            this.txtCustomUploadersConfigPath.TabIndex = 5;
            this.txtCustomUploadersConfigPath.TextChanged += new System.EventHandler(this.txtCustomUploadersConfigPath_TextChanged);
            // 
            // cbUseCustomUploadersConfigPath
            // 
            this.cbUseCustomUploadersConfigPath.AutoSize = true;
            this.cbUseCustomUploadersConfigPath.Location = new System.Drawing.Point(16, 24);
            this.cbUseCustomUploadersConfigPath.Name = "cbUseCustomUploadersConfigPath";
            this.cbUseCustomUploadersConfigPath.Size = new System.Drawing.Size(206, 17);
            this.cbUseCustomUploadersConfigPath.TabIndex = 4;
            this.cbUseCustomUploadersConfigPath.Text = "Use custom uploaders config file path:";
            this.cbUseCustomUploadersConfigPath.UseVisualStyleBackColor = true;
            this.cbUseCustomUploadersConfigPath.CheckedChanged += new System.EventHandler(this.cbUseCustomUploadersConfigPath_CheckedChanged);
            // 
            // gbHistory
            // 
            this.gbHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHistory.Controls.Add(this.nudHistoryMaxItemCount);
            this.gbHistory.Controls.Add(this.lblHistoryMaxItemCount);
            this.gbHistory.Controls.Add(this.btnBrowseCustomHistoryPath);
            this.gbHistory.Controls.Add(this.txtCustomHistoryPath);
            this.gbHistory.Controls.Add(this.cbUseCustomHistoryPath);
            this.gbHistory.Controls.Add(this.cbHistorySave);
            this.gbHistory.Location = new System.Drawing.Point(8, 216);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(520, 136);
            this.gbHistory.TabIndex = 0;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "History";
            // 
            // nudHistoryMaxItemCount
            // 
            this.nudHistoryMaxItemCount.Location = new System.Drawing.Point(216, 100);
            this.nudHistoryMaxItemCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudHistoryMaxItemCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudHistoryMaxItemCount.Name = "nudHistoryMaxItemCount";
            this.nudHistoryMaxItemCount.Size = new System.Drawing.Size(80, 20);
            this.nudHistoryMaxItemCount.TabIndex = 11;
            this.nudHistoryMaxItemCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHistoryMaxItemCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudHistoryMaxItemCount.ValueChanged += new System.EventHandler(this.nudHistoryMaxItemCount_ValueChanged);
            // 
            // lblHistoryMaxItemCount
            // 
            this.lblHistoryMaxItemCount.AutoSize = true;
            this.lblHistoryMaxItemCount.Location = new System.Drawing.Point(16, 104);
            this.lblHistoryMaxItemCount.Name = "lblHistoryMaxItemCount";
            this.lblHistoryMaxItemCount.Size = new System.Drawing.Size(192, 13);
            this.lblHistoryMaxItemCount.TabIndex = 10;
            this.lblHistoryMaxItemCount.Text = "Max item count for filtering (-1 disables):";
            // 
            // btnBrowseCustomHistoryPath
            // 
            this.btnBrowseCustomHistoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseCustomHistoryPath.AutoSize = true;
            this.btnBrowseCustomHistoryPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseCustomHistoryPath.Location = new System.Drawing.Point(448, 72);
            this.btnBrowseCustomHistoryPath.Name = "btnBrowseCustomHistoryPath";
            this.btnBrowseCustomHistoryPath.Size = new System.Drawing.Size(61, 23);
            this.btnBrowseCustomHistoryPath.TabIndex = 9;
            this.btnBrowseCustomHistoryPath.Text = "Browse...";
            this.btnBrowseCustomHistoryPath.UseVisualStyleBackColor = true;
            this.btnBrowseCustomHistoryPath.Click += new System.EventHandler(this.btnBrowseCustomHistoryPath_Click);
            // 
            // txtCustomHistoryPath
            // 
            this.txtCustomHistoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomHistoryPath.Location = new System.Drawing.Point(16, 72);
            this.txtCustomHistoryPath.Name = "txtCustomHistoryPath";
            this.txtCustomHistoryPath.Size = new System.Drawing.Size(424, 20);
            this.txtCustomHistoryPath.TabIndex = 8;
            this.txtCustomHistoryPath.TextChanged += new System.EventHandler(this.txtCustomHistoryPath_TextChanged);
            // 
            // cbUseCustomHistoryPath
            // 
            this.cbUseCustomHistoryPath.AutoSize = true;
            this.cbUseCustomHistoryPath.Location = new System.Drawing.Point(16, 48);
            this.cbUseCustomHistoryPath.Name = "cbUseCustomHistoryPath";
            this.cbUseCustomHistoryPath.Size = new System.Drawing.Size(158, 17);
            this.cbUseCustomHistoryPath.TabIndex = 7;
            this.cbUseCustomHistoryPath.Text = "Use custom history file path:";
            this.cbUseCustomHistoryPath.UseVisualStyleBackColor = true;
            this.cbUseCustomHistoryPath.CheckedChanged += new System.EventHandler(this.cbUseCustomHistoryPath_CheckedChanged);
            // 
            // cbHistorySave
            // 
            this.cbHistorySave.AutoSize = true;
            this.cbHistorySave.Location = new System.Drawing.Point(16, 24);
            this.cbHistorySave.Name = "cbHistorySave";
            this.cbHistorySave.Size = new System.Drawing.Size(118, 17);
            this.cbHistorySave.TabIndex = 6;
            this.cbHistorySave.Text = "Enable history save";
            this.cbHistorySave.UseVisualStyleBackColor = true;
            this.cbHistorySave.CheckedChanged += new System.EventHandler(this.cbHistorySave_CheckedChanged);
            // 
            // tpAfterUpload
            // 
            this.tpAfterUpload.Controls.Add(this.panelAfterUpload);
            this.tpAfterUpload.Location = new System.Drawing.Point(4, 22);
            this.tpAfterUpload.Name = "tpAfterUpload";
            this.tpAfterUpload.Padding = new System.Windows.Forms.Padding(3);
            this.tpAfterUpload.Size = new System.Drawing.Size(543, 488);
            this.tpAfterUpload.TabIndex = 11;
            this.tpAfterUpload.Text = "After Upload";
            this.tpAfterUpload.UseVisualStyleBackColor = true;
            // 
            // panelAfterUpload
            // 
            this.panelAfterUpload.Controls.Add(this.cbURLShortenAfterUpload);
            this.panelAfterUpload.Controls.Add(this.cbClipboardAutoCopy);
            this.panelAfterUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAfterUpload.Location = new System.Drawing.Point(3, 3);
            this.panelAfterUpload.Name = "panelAfterUpload";
            this.panelAfterUpload.Size = new System.Drawing.Size(537, 482);
            this.panelAfterUpload.TabIndex = 0;
            // 
            // cbURLShortenAfterUpload
            // 
            this.cbURLShortenAfterUpload.AutoSize = true;
            this.cbURLShortenAfterUpload.Location = new System.Drawing.Point(16, 16);
            this.cbURLShortenAfterUpload.Name = "cbURLShortenAfterUpload";
            this.cbURLShortenAfterUpload.Size = new System.Drawing.Size(240, 17);
            this.cbURLShortenAfterUpload.TabIndex = 8;
            this.cbURLShortenAfterUpload.Text = "Use URL Shortener after upload is completed";
            this.cbURLShortenAfterUpload.UseVisualStyleBackColor = true;
            this.cbURLShortenAfterUpload.CheckedChanged += new System.EventHandler(this.cbURLShortenAfterUpload_CheckedChanged);
            // 
            // cbClipboardAutoCopy
            // 
            this.cbClipboardAutoCopy.AutoSize = true;
            this.cbClipboardAutoCopy.Location = new System.Drawing.Point(16, 40);
            this.cbClipboardAutoCopy.Name = "cbClipboardAutoCopy";
            this.cbClipboardAutoCopy.Size = new System.Drawing.Size(254, 17);
            this.cbClipboardAutoCopy.TabIndex = 7;
            this.cbClipboardAutoCopy.Text = "Copy URL to clipboard after upload is completed";
            this.cbClipboardAutoCopy.UseVisualStyleBackColor = true;
            this.cbClipboardAutoCopy.CheckedChanged += new System.EventHandler(this.cbClipboardAutoCopy_CheckedChanged);
            // 
            // OptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 566);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(720, 600);
            this.Name = "OptionsWindow";
            this.Text = "OptionsWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsWindow_FormClosed);
            this.Shown += new System.EventHandler(this.OptionsWindow_Shown);
            this.Resize += new System.EventHandler(this.OptionsWindow_Resize);
            this.tlpMain.ResumeLayout(false);
            this.tcBase.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.gbNotifications.ResumeLayout(false);
            this.gbNotifications.PerformLayout();
            this.tpAdvanced.ResumeLayout(false);
            this.panelAdvanced.ResumeLayout(false);
            this.tpCapture.ResumeLayout(false);
            this.panelCapture.ResumeLayout(false);
            this.panelCapture.PerformLayout();
            this.gbCaptureAfter.ResumeLayout(false);
            this.gbCaptureAfter.PerformLayout();
            this.tpShapes.ResumeLayout(false);
            this.panelShapes.ResumeLayout(false);
            this.panelShapes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFixedShapeSizeHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFixedShapeSizeWidth)).EndInit();
            this.tpProxy.ResumeLayout(false);
            this.panelProxy.ResumeLayout(false);
            this.tpClipboardUpload.ResumeLayout(false);
            this.panelClipboardUpload.ResumeLayout(false);
            this.panelClipboardUpload.PerformLayout();
            this.tpUpload.ResumeLayout(false);
            this.panelUpload.ResumeLayout(false);
            this.panelUpload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUploadLimit)).EndInit();
            this.tpHotkeys.ResumeLayout(false);
            this.panelHotkeys.ResumeLayout(false);
            this.tpImageQuality.ResumeLayout(false);
            this.panelImageQuality.ResumeLayout(false);
            this.panelImageQuality.PerformLayout();
            this.gbImageScaleSettings.ResumeLayout(false);
            this.gbImageScaleSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageScalePercentageWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageScaleToHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageScalePercentageHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageScaleToWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageScaleSpecificHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageScaleSpecificWidth)).EndInit();
            this.tpImageResize.ResumeLayout(false);
            this.panelImageResize.ResumeLayout(false);
            this.panelImageResize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageJPEGQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUseImageFormat2After)).EndInit();
            this.tpPaths.ResumeLayout(false);
            this.panelPaths.ResumeLayout(false);
            this.gbPathRoot.ResumeLayout(false);
            this.gbPathRoot.PerformLayout();
            this.gbScreenshots.ResumeLayout(false);
            this.gbScreenshots.PerformLayout();
            this.gbUploadersConfig.ResumeLayout(false);
            this.gbUploadersConfig.PerformLayout();
            this.gbHistory.ResumeLayout(false);
            this.gbHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHistoryMaxItemCount)).EndInit();
            this.tpAfterUpload.ResumeLayout(false);
            this.panelAfterUpload.ResumeLayout(false);
            this.panelAfterUpload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Panel panelCapture;
        private System.Windows.Forms.Panel panelShapes;
        private System.Windows.Forms.Panel panelAdvanced;
        private System.Windows.Forms.Panel panelProxy;
        private System.Windows.Forms.Panel panelClipboardUpload;
        private System.Windows.Forms.CheckBox cbCheckUpdates;
        private System.Windows.Forms.CheckBox cbStartWithWindows;
        private System.Windows.Forms.CheckBox cbShowTray;
        private System.Windows.Forms.CheckBox cbShellContextMenu;
        private System.Windows.Forms.CheckBox cbCaptureShadow;
        private System.Windows.Forms.CheckBox cbShowCursor;
        private System.Windows.Forms.CheckBox cbCaptureTransparent;
        private System.Windows.Forms.Label lblGeneralInfo;
        private System.Windows.Forms.PropertyGrid pgSettings;
        private System.Windows.Forms.TabControl tcBase;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpAdvanced;
        private System.Windows.Forms.TabPage tpCapture;
        private System.Windows.Forms.TabPage tpShapes;
        private System.Windows.Forms.TabPage tpProxy;
        private System.Windows.Forms.TabPage tpClipboardUpload;
        private System.Windows.Forms.TabPage tpUpload;
        private System.Windows.Forms.Panel panelUpload;
        private System.Windows.Forms.Button btnAutofillProxy;
        private System.Windows.Forms.PropertyGrid pgProxy;
        private System.Windows.Forms.GroupBox gbCaptureAfter;
        private System.Windows.Forms.TextBox txtSaveImageSubFolderPatternPreview;
        private System.Windows.Forms.Button btnBrowseScreenshotsDir;
        private System.Windows.Forms.TextBox txtScreenshotsPath;
        private System.Windows.Forms.CheckBox chkCaptureAnnotateImage;
        private System.Windows.Forms.TextBox txtSaveImageSubFolderPattern;
        private System.Windows.Forms.Label lblSaveImageSubFolderPattern;
        private System.Windows.Forms.CheckBox cbCaptureUploadImage;
        private System.Windows.Forms.CheckBox cbCaptureSaveImage;
        private System.Windows.Forms.CheckBox cbCaptureCopyImage;
        private System.Windows.Forms.CheckBox cbShapeForceWindowCapture;
        private System.Windows.Forms.CheckBox cbShapeIncludeControls;
        private System.Windows.Forms.Label lblFixedShapeSizeHeight;
        private System.Windows.Forms.CheckBox cbDrawBorder;
        private System.Windows.Forms.Label lblFixedShapeSizeWidth;
        private System.Windows.Forms.CheckBox cbQuickCrop;
        private System.Windows.Forms.NumericUpDown nudFixedShapeSizeHeight;
        private System.Windows.Forms.CheckBox cbDrawCheckerboard;
        private System.Windows.Forms.NumericUpDown nudFixedShapeSizeWidth;
        private System.Windows.Forms.CheckBox cbFixedShapeSize;
        private System.Windows.Forms.TabPage tpHotkeys;
        private System.Windows.Forms.Panel panelHotkeys;
        private HelpersLib.Hotkeys2.HotkeyManagerControl hmHotkeys;
        private System.Windows.Forms.CheckBox cbClipboardUploadAutoDetectURL;
        private System.Windows.Forms.Label lblClipboardUploadInfo;
        private System.Windows.Forms.Label lblNameFormatPatternPreview;
        private System.Windows.Forms.Label lblNameFormatPattern;
        private System.Windows.Forms.Button btnNameFormatPatternHelp;
        private System.Windows.Forms.TextBox txtNameFormatPattern;
        private System.Windows.Forms.TabPage tpImageQuality;
        private System.Windows.Forms.Panel panelImageQuality;
        private System.Windows.Forms.CheckBox cbImageUseSmoothScaling;
        private System.Windows.Forms.CheckBox cbImageKeepAspectRatio;
        private System.Windows.Forms.CheckBox cbImageAutoResize;
        private System.Windows.Forms.GroupBox gbImageScaleSettings;
        private System.Windows.Forms.RadioButton rbImageScaleTypePercentage;
        private System.Windows.Forms.Label lblImageScaleToHeight2;
        private System.Windows.Forms.RadioButton rbImageScaleTypeToWidth;
        private System.Windows.Forms.Label lblImageScaleSpecificWidth2;
        private System.Windows.Forms.RadioButton rbImageScaleTypeToHeight;
        private System.Windows.Forms.Label lblImageScaleSpecificHeight2;
        private System.Windows.Forms.RadioButton rbImageScaleTypeSpecific;
        private System.Windows.Forms.Label lblImageScaleToWidth2;
        private System.Windows.Forms.Label lblImageScalePercentageWidth;
        private System.Windows.Forms.Label lblImageScalePercentageHeight2;
        private System.Windows.Forms.NumericUpDown nudImageScalePercentageWidth;
        private System.Windows.Forms.Label lblImageScalePercentageWidth2;
        private System.Windows.Forms.Label lblImageScalePercentageHeight;
        private System.Windows.Forms.NumericUpDown nudImageScaleToHeight;
        private System.Windows.Forms.NumericUpDown nudImageScalePercentageHeight;
        private System.Windows.Forms.NumericUpDown nudImageScaleToWidth;
        private System.Windows.Forms.Label lblImageScaleToWidth;
        private System.Windows.Forms.NumericUpDown nudImageScaleSpecificHeight;
        private System.Windows.Forms.Label lblImageScaleToHeight;
        private System.Windows.Forms.Label lblImageScaleSpecificHeight;
        private System.Windows.Forms.Label lblImageScaleSpecificWidth;
        private System.Windows.Forms.NumericUpDown nudImageScaleSpecificWidth;
        private System.Windows.Forms.TabPage tpImageResize;
        private System.Windows.Forms.Panel panelImageResize;
        private System.Windows.Forms.Label lblImageFormat;
        private System.Windows.Forms.Label lblUseImageFormat2AfterHint;
        private System.Windows.Forms.ComboBox cbImageFormat;
        private System.Windows.Forms.Label lblImageJPEGQualityHint;
        private System.Windows.Forms.Label lblImageJPEGQuality;
        private System.Windows.Forms.ComboBox cbImageGIFQuality;
        private System.Windows.Forms.Label lblImageGIFQuality;
        private System.Windows.Forms.ComboBox cbImageFormat2;
        private System.Windows.Forms.NumericUpDown nudImageJPEGQuality;
        private System.Windows.Forms.Label lblImageFormat2;
        private System.Windows.Forms.NumericUpDown nudUseImageFormat2After;
        private System.Windows.Forms.Label lblUseImageFormat2After;
        private System.Windows.Forms.TabPage tpPaths;
        private System.Windows.Forms.Panel panelPaths;
        private System.Windows.Forms.GroupBox gbHistory;
        private System.Windows.Forms.NumericUpDown nudHistoryMaxItemCount;
        private System.Windows.Forms.Label lblHistoryMaxItemCount;
        private System.Windows.Forms.Button btnBrowseCustomHistoryPath;
        private System.Windows.Forms.TextBox txtCustomHistoryPath;
        private System.Windows.Forms.CheckBox cbUseCustomHistoryPath;
        private System.Windows.Forms.CheckBox cbHistorySave;
        private System.Windows.Forms.Label lblUploadLimitHint;
        private System.Windows.Forms.NumericUpDown nudUploadLimit;
        private System.Windows.Forms.Label lblUploadLimit;
        private System.Windows.Forms.Label lblBufferSize;
        private System.Windows.Forms.Label lblBufferSizeInfo;
        private System.Windows.Forms.ComboBox cbBufferSize;
        private System.Windows.Forms.GroupBox gbUploadersConfig;
        private System.Windows.Forms.Button btnLoadUploadersConfig;
        private System.Windows.Forms.Button btnBrowseCustomUploadersConfigPath;
        private System.Windows.Forms.TextBox txtCustomUploadersConfigPath;
        private System.Windows.Forms.CheckBox cbUseCustomUploadersConfigPath;
        private System.Windows.Forms.Label lblOpenZUploaderPath;
        private System.Windows.Forms.Button btnOpenZUploaderPath;
        private System.Windows.Forms.CheckBox cbPlaySoundAfterCapture;
        private System.Windows.Forms.TabPage tpAfterUpload;
        private System.Windows.Forms.Panel panelAfterUpload;
        private System.Windows.Forms.CheckBox cbURLShortenAfterUpload;
        private System.Windows.Forms.CheckBox cbClipboardAutoCopy;
        private System.Windows.Forms.GroupBox gbNotifications;
        private System.Windows.Forms.GroupBox gbPathRoot;
        private System.Windows.Forms.GroupBox gbScreenshots;
        private System.Windows.Forms.CheckBox chkPlaySoundAfterUpload;
    }
}