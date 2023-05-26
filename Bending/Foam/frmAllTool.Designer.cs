namespace Bending.Foam
{
    partial class frmAllTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllTool));
            this.tcAllTools = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.InfoBox = new System.Windows.Forms.TextBox();
            this.btnInspect = new System.Windows.Forms.Button();
            this.PostInspectDispStatusBar = new Cognex.VisionPro.CogDisplayStatusBarV2();
            this.PostInspectDisplay = new Cognex.VisionPro.Display.CogDisplay();
            this.PreInspectDispStatusBar = new Cognex.VisionPro.CogDisplayStatusBarV2();
            this.PreInspectDisplay = new Cognex.VisionPro.Display.CogDisplay();
            this.tbPMAlign = new System.Windows.Forms.TabPage();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.gbPatMax = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtPatMaxScoreValue = new System.Windows.Forms.TextBox();
            this.btnPatMaxRun = new System.Windows.Forms.Button();
            this.btnSetupPatMax = new System.Windows.Forms.Button();
            this.cdDisplay = new Cognex.VisionPro.Display.CogDisplay();
            this.gbImageAcquisition = new System.Windows.Forms.GroupBox();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.rbImageFile = new System.Windows.Forms.RadioButton();
            this.rbFramGrapbber = new System.Windows.Forms.RadioButton();
            this.tcAllTools.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostInspectDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreInspectDisplay)).BeginInit();
            this.tbPMAlign.SuspendLayout();
            this.gbPatMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdDisplay)).BeginInit();
            this.gbImageAcquisition.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAllTools
            // 
            this.tcAllTools.Controls.Add(this.tabPage1);
            this.tcAllTools.Controls.Add(this.tbPMAlign);
            this.tcAllTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAllTools.Location = new System.Drawing.Point(0, 0);
            this.tcAllTools.Name = "tcAllTools";
            this.tcAllTools.SelectedIndex = 0;
            this.tcAllTools.Size = new System.Drawing.Size(1032, 654);
            this.tcAllTools.TabIndex = 0;
            this.tcAllTools.SelectedIndexChanged += new System.EventHandler(this.tcAllTools_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.InfoBox);
            this.tabPage1.Controls.Add(this.btnInspect);
            this.tabPage1.Controls.Add(this.PostInspectDispStatusBar);
            this.tabPage1.Controls.Add(this.PostInspectDisplay);
            this.tabPage1.Controls.Add(this.PreInspectDispStatusBar);
            this.tabPage1.Controls.Add(this.PreInspectDisplay);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1024, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // InfoBox
            // 
            this.InfoBox.AcceptsReturn = true;
            this.InfoBox.Location = new System.Drawing.Point(131, 431);
            this.InfoBox.Multiline = true;
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoBox.Size = new System.Drawing.Size(696, 152);
            this.InfoBox.TabIndex = 9;
            // 
            // btnInspect
            // 
            this.btnInspect.Location = new System.Drawing.Point(88, 49);
            this.btnInspect.Name = "btnInspect";
            this.btnInspect.Size = new System.Drawing.Size(216, 72);
            this.btnInspect.TabIndex = 8;
            this.btnInspect.Text = "Load Next Image and Inspect";
            // 
            // PostInspectDispStatusBar
            // 
            this.PostInspectDispStatusBar.CoordinateSpaceName = "*\\#";
            this.PostInspectDispStatusBar.CoordinateSpaceName3D = "*\\#";
            this.PostInspectDispStatusBar.Location = new System.Drawing.Point(531, 374);
            this.PostInspectDispStatusBar.Name = "PostInspectDispStatusBar";
            this.PostInspectDispStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PostInspectDispStatusBar.Size = new System.Drawing.Size(312, 21);
            this.PostInspectDispStatusBar.TabIndex = 7;
            this.PostInspectDispStatusBar.Use3DCoordinateSpaceTree = false;
            // 
            // PostInspectDisplay
            // 
            this.PostInspectDisplay.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.PostInspectDisplay.ColorMapLowerRoiLimit = 0D;
            this.PostInspectDisplay.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.PostInspectDisplay.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.PostInspectDisplay.ColorMapUpperRoiLimit = 1D;
            this.PostInspectDisplay.DoubleTapZoomCycleLength = 2;
            this.PostInspectDisplay.DoubleTapZoomSensitivity = 2.5D;
            this.PostInspectDisplay.Location = new System.Drawing.Point(523, 174);
            this.PostInspectDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.PostInspectDisplay.MouseWheelSensitivity = 1D;
            this.PostInspectDisplay.Name = "PostInspectDisplay";
            this.PostInspectDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PostInspectDisplay.OcxState")));
            this.PostInspectDisplay.Size = new System.Drawing.Size(320, 192);
            this.PostInspectDisplay.TabIndex = 6;
            // 
            // PreInspectDispStatusBar
            // 
            this.PreInspectDispStatusBar.CoordinateSpaceName = "*\\#";
            this.PreInspectDispStatusBar.CoordinateSpaceName3D = "*\\#";
            this.PreInspectDispStatusBar.Location = new System.Drawing.Point(88, 372);
            this.PreInspectDispStatusBar.Name = "PreInspectDispStatusBar";
            this.PreInspectDispStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PreInspectDispStatusBar.Size = new System.Drawing.Size(336, 21);
            this.PreInspectDispStatusBar.TabIndex = 5;
            this.PreInspectDispStatusBar.Use3DCoordinateSpaceTree = false;
            // 
            // PreInspectDisplay
            // 
            this.PreInspectDisplay.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.PreInspectDisplay.ColorMapLowerRoiLimit = 0D;
            this.PreInspectDisplay.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.PreInspectDisplay.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.PreInspectDisplay.ColorMapUpperRoiLimit = 1D;
            this.PreInspectDisplay.DoubleTapZoomCycleLength = 2;
            this.PreInspectDisplay.DoubleTapZoomSensitivity = 2.5D;
            this.PreInspectDisplay.Location = new System.Drawing.Point(88, 174);
            this.PreInspectDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.PreInspectDisplay.MouseWheelSensitivity = 1D;
            this.PreInspectDisplay.Name = "PreInspectDisplay";
            this.PreInspectDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PreInspectDisplay.OcxState")));
            this.PreInspectDisplay.Size = new System.Drawing.Size(336, 192);
            this.PreInspectDisplay.TabIndex = 1;
            // 
            // tbPMAlign
            // 
            this.tbPMAlign.Controls.Add(this.txtInfo);
            this.tbPMAlign.Controls.Add(this.gbPatMax);
            this.tbPMAlign.Controls.Add(this.cdDisplay);
            this.tbPMAlign.Controls.Add(this.gbImageAcquisition);
            this.tbPMAlign.Location = new System.Drawing.Point(4, 22);
            this.tbPMAlign.Name = "tbPMAlign";
            this.tbPMAlign.Padding = new System.Windows.Forms.Padding(3);
            this.tbPMAlign.Size = new System.Drawing.Size(1024, 628);
            this.tbPMAlign.TabIndex = 1;
            this.tbPMAlign.Text = "PMAlign";
            this.tbPMAlign.UseVisualStyleBackColor = true;
            this.tbPMAlign.Enter += new System.EventHandler(this.tbPMAlign_Enter);
            // 
            // txtInfo
            // 
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtInfo.Location = new System.Drawing.Point(3, 513);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(1018, 112);
            this.txtInfo.TabIndex = 5;
            // 
            // gbPatMax
            // 
            this.gbPatMax.Controls.Add(this.Label1);
            this.gbPatMax.Controls.Add(this.txtPatMaxScoreValue);
            this.gbPatMax.Controls.Add(this.btnPatMaxRun);
            this.gbPatMax.Controls.Add(this.btnSetupPatMax);
            this.gbPatMax.Location = new System.Drawing.Point(35, 229);
            this.gbPatMax.Name = "gbPatMax";
            this.gbPatMax.Size = new System.Drawing.Size(392, 128);
            this.gbPatMax.TabIndex = 4;
            this.gbPatMax.TabStop = false;
            this.gbPatMax.Text = "Pat Max";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(232, 56);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 32);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Score";
            // 
            // txtPatMaxScoreValue
            // 
            this.txtPatMaxScoreValue.Location = new System.Drawing.Point(296, 40);
            this.txtPatMaxScoreValue.Multiline = true;
            this.txtPatMaxScoreValue.Name = "txtPatMaxScoreValue";
            this.txtPatMaxScoreValue.Size = new System.Drawing.Size(80, 40);
            this.txtPatMaxScoreValue.TabIndex = 2;
            // 
            // btnPatMaxRun
            // 
            this.btnPatMaxRun.Location = new System.Drawing.Point(112, 40);
            this.btnPatMaxRun.Name = "btnPatMaxRun";
            this.btnPatMaxRun.Size = new System.Drawing.Size(104, 48);
            this.btnPatMaxRun.TabIndex = 1;
            this.btnPatMaxRun.Text = "Run";
            // 
            // btnSetupPatMax
            // 
            this.btnSetupPatMax.Location = new System.Drawing.Point(8, 40);
            this.btnSetupPatMax.Name = "btnSetupPatMax";
            this.btnSetupPatMax.Size = new System.Drawing.Size(96, 48);
            this.btnSetupPatMax.TabIndex = 0;
            this.btnSetupPatMax.Text = "Setup";
            // 
            // cdDisplay
            // 
            this.cdDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cdDisplay.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cdDisplay.ColorMapLowerRoiLimit = 0D;
            this.cdDisplay.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cdDisplay.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cdDisplay.ColorMapUpperRoiLimit = 1D;
            this.cdDisplay.DoubleTapZoomCycleLength = 2;
            this.cdDisplay.DoubleTapZoomSensitivity = 2.5D;
            this.cdDisplay.Location = new System.Drawing.Point(591, 23);
            this.cdDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdDisplay.MouseWheelSensitivity = 1D;
            this.cdDisplay.Name = "cdDisplay";
            this.cdDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdDisplay.OcxState")));
            this.cdDisplay.Size = new System.Drawing.Size(357, 421);
            this.cdDisplay.TabIndex = 3;
            // 
            // gbImageAcquisition
            // 
            this.gbImageAcquisition.Controls.Add(this.btnNextImage);
            this.gbImageAcquisition.Controls.Add(this.btnOpenFile);
            this.gbImageAcquisition.Controls.Add(this.rbImageFile);
            this.gbImageAcquisition.Controls.Add(this.rbFramGrapbber);
            this.gbImageAcquisition.Location = new System.Drawing.Point(35, 62);
            this.gbImageAcquisition.Name = "gbImageAcquisition";
            this.gbImageAcquisition.Size = new System.Drawing.Size(384, 136);
            this.gbImageAcquisition.TabIndex = 2;
            this.gbImageAcquisition.TabStop = false;
            this.gbImageAcquisition.Text = "Image Acquisition";
            // 
            // btnNextImage
            // 
            this.btnNextImage.Location = new System.Drawing.Point(280, 48);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(75, 40);
            this.btnNextImage.TabIndex = 3;
            this.btnNextImage.Text = "Next Image";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(152, 48);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 40);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // rbImageFile
            // 
            this.rbImageFile.Checked = true;
            this.rbImageFile.Location = new System.Drawing.Point(24, 64);
            this.rbImageFile.Name = "rbImageFile";
            this.rbImageFile.Size = new System.Drawing.Size(104, 24);
            this.rbImageFile.TabIndex = 1;
            this.rbImageFile.TabStop = true;
            this.rbImageFile.Text = "Image File";
            // 
            // rbFramGrapbber
            // 
            this.rbFramGrapbber.Location = new System.Drawing.Point(24, 32);
            this.rbFramGrapbber.Name = "rbFramGrapbber";
            this.rbFramGrapbber.Size = new System.Drawing.Size(104, 24);
            this.rbFramGrapbber.TabIndex = 0;
            this.rbFramGrapbber.Text = "Frame Grabber";
            this.rbFramGrapbber.CheckedChanged += new System.EventHandler(this.rbFramGrapbber_CheckedChanged);
            // 
            // frmAllTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 654);
            this.Controls.Add(this.tcAllTools);
            this.Name = "frmAllTool";
            this.Text = "frmAllTool";
            this.tcAllTools.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostInspectDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreInspectDisplay)).EndInit();
            this.tbPMAlign.ResumeLayout(false);
            this.tbPMAlign.PerformLayout();
            this.gbPatMax.ResumeLayout(false);
            this.gbPatMax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdDisplay)).EndInit();
            this.gbImageAcquisition.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAllTools;
        private System.Windows.Forms.TabPage tabPage1;
        internal Cognex.VisionPro.Display.CogDisplay PreInspectDisplay;
        private System.Windows.Forms.TabPage tbPMAlign;
        internal System.Windows.Forms.TextBox InfoBox;
        internal System.Windows.Forms.Button btnInspect;
        internal Cognex.VisionPro.CogDisplayStatusBarV2 PostInspectDispStatusBar;
        internal Cognex.VisionPro.Display.CogDisplay PostInspectDisplay;
        internal Cognex.VisionPro.CogDisplayStatusBarV2 PreInspectDispStatusBar;
        internal System.Windows.Forms.TextBox txtInfo;
        internal System.Windows.Forms.GroupBox gbPatMax;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtPatMaxScoreValue;
        private System.Windows.Forms.Button btnPatMaxRun;
        private System.Windows.Forms.Button btnSetupPatMax;
        internal Cognex.VisionPro.Display.CogDisplay cdDisplay;
        internal System.Windows.Forms.GroupBox gbImageAcquisition;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.RadioButton rbImageFile;
        private System.Windows.Forms.RadioButton rbFramGrapbber;
    }
}