namespace Bending.Foam
{
    partial class PMAlign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PMAlign));
            this.gbImageAcq = new System.Windows.Forms.GroupBox();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.rbImageFile = new System.Windows.Forms.RadioButton();
            this.rbFrameGrabber = new System.Windows.Forms.RadioButton();
            this.gbPMAlign = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtbScore = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.cdDisplay = new Cognex.VisionPro.Display.CogDisplay();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cdSmall = new Cognex.VisionPro.Display.CogDisplay();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnShow1 = new System.Windows.Forms.Button();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.btnShow3 = new System.Windows.Forms.Button();
            this.btnShow4 = new System.Windows.Forms.Button();
            this.cogDisplay1 = new Cognex.VisionPro.Display.CogDisplay();
            this.gbImageAcq.SuspendLayout();
            this.gbPMAlign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbImageAcq
            // 
            this.gbImageAcq.Controls.Add(this.btnNextImage);
            this.gbImageAcq.Controls.Add(this.btnOpenFile);
            this.gbImageAcq.Controls.Add(this.rbImageFile);
            this.gbImageAcq.Controls.Add(this.rbFrameGrabber);
            this.gbImageAcq.Location = new System.Drawing.Point(26, 50);
            this.gbImageAcq.Name = "gbImageAcq";
            this.gbImageAcq.Size = new System.Drawing.Size(384, 97);
            this.gbImageAcq.TabIndex = 2;
            this.gbImageAcq.TabStop = false;
            this.gbImageAcq.Text = "Image Acquisition";
            // 
            // btnNextImage
            // 
            this.btnNextImage.Location = new System.Drawing.Point(280, 37);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(75, 40);
            this.btnNextImage.TabIndex = 3;
            this.btnNextImage.Text = "Next Image";
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(152, 37);
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
            // rbFrameGrabber
            // 
            this.rbFrameGrabber.Location = new System.Drawing.Point(24, 32);
            this.rbFrameGrabber.Name = "rbFrameGrabber";
            this.rbFrameGrabber.Size = new System.Drawing.Size(104, 24);
            this.rbFrameGrabber.TabIndex = 0;
            this.rbFrameGrabber.Text = "Frame Grabber";
            this.rbFrameGrabber.CheckedChanged += new System.EventHandler(this.rbFrameGrabber_CheckedChanged);
            // 
            // gbPMAlign
            // 
            this.gbPMAlign.Controls.Add(this.Label1);
            this.gbPMAlign.Controls.Add(this.txtbScore);
            this.gbPMAlign.Controls.Add(this.btnRun);
            this.gbPMAlign.Controls.Add(this.btnSetup);
            this.gbPMAlign.Location = new System.Drawing.Point(26, 171);
            this.gbPMAlign.Name = "gbPMAlign";
            this.gbPMAlign.Size = new System.Drawing.Size(392, 95);
            this.gbPMAlign.TabIndex = 3;
            this.gbPMAlign.TabStop = false;
            this.gbPMAlign.Text = "PMAlign Tool";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(232, 44);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 32);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Score";
            // 
            // txtbScore
            // 
            this.txtbScore.Location = new System.Drawing.Point(296, 28);
            this.txtbScore.Multiline = true;
            this.txtbScore.Name = "txtbScore";
            this.txtbScore.Size = new System.Drawing.Size(80, 40);
            this.txtbScore.TabIndex = 2;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(112, 28);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(104, 48);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(8, 28);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(96, 48);
            this.btnSetup.TabIndex = 0;
            this.btnSetup.Text = "Setup";
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
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
            this.cdDisplay.Location = new System.Drawing.Point(453, 33);
            this.cdDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdDisplay.MouseWheelSensitivity = 1D;
            this.cdDisplay.Name = "cdDisplay";
            this.cdDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdDisplay.OcxState")));
            this.cdDisplay.Size = new System.Drawing.Size(392, 435);
            this.cdDisplay.TabIndex = 4;
            // 
            // txtInfo
            // 
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtInfo.Location = new System.Drawing.Point(0, 705);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(1064, 55);
            this.txtInfo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // cdSmall
            // 
            this.cdSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cdSmall.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cdSmall.ColorMapLowerRoiLimit = 0D;
            this.cdSmall.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cdSmall.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cdSmall.ColorMapUpperRoiLimit = 1D;
            this.cdSmall.DoubleTapZoomCycleLength = 2;
            this.cdSmall.DoubleTapZoomSensitivity = 2.5D;
            this.cdSmall.Location = new System.Drawing.Point(453, 489);
            this.cdSmall.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdSmall.MouseWheelSensitivity = 1D;
            this.cdSmall.Name = "cdSmall";
            this.cdSmall.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdSmall.OcxState")));
            this.cdSmall.Size = new System.Drawing.Size(205, 190);
            this.cdSmall.TabIndex = 9;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(26, 419);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "ShowImageTrained";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnShow1
            // 
            this.btnShow1.Location = new System.Drawing.Point(26, 477);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.Size = new System.Drawing.Size(75, 23);
            this.btnShow1.TabIndex = 11;
            this.btnShow1.Text = "Show1";
            this.btnShow1.UseVisualStyleBackColor = true;
            this.btnShow1.Click += new System.EventHandler(this.btnShow1_Click);
            // 
            // btnShow2
            // 
            this.btnShow2.Location = new System.Drawing.Point(26, 530);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(75, 23);
            this.btnShow2.TabIndex = 12;
            this.btnShow2.Text = "Show2";
            this.btnShow2.UseVisualStyleBackColor = true;
            this.btnShow2.Click += new System.EventHandler(this.btnShow2_Click);
            // 
            // btnShow3
            // 
            this.btnShow3.Location = new System.Drawing.Point(135, 419);
            this.btnShow3.Name = "btnShow3";
            this.btnShow3.Size = new System.Drawing.Size(75, 23);
            this.btnShow3.TabIndex = 13;
            this.btnShow3.Text = "Show3";
            this.btnShow3.UseVisualStyleBackColor = true;
            this.btnShow3.Click += new System.EventHandler(this.btnShow3_Click);
            // 
            // btnShow4
            // 
            this.btnShow4.Location = new System.Drawing.Point(135, 477);
            this.btnShow4.Name = "btnShow4";
            this.btnShow4.Size = new System.Drawing.Size(75, 23);
            this.btnShow4.TabIndex = 14;
            this.btnShow4.Text = "Show4";
            this.btnShow4.UseVisualStyleBackColor = true;
            this.btnShow4.Click += new System.EventHandler(this.btnShow4_Click);
            // 
            // cogDisplay1
            // 
            this.cogDisplay1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cogDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay1.Location = new System.Drawing.Point(710, 489);
            this.cogDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay1.MouseWheelSensitivity = 1D;
            this.cogDisplay1.Name = "cogDisplay1";
            this.cogDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay1.OcxState")));
            this.cogDisplay1.Size = new System.Drawing.Size(205, 190);
            this.cogDisplay1.TabIndex = 15;
            // 
            // PMAlign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 760);
            this.Controls.Add(this.cogDisplay1);
            this.Controls.Add(this.btnShow4);
            this.Controls.Add(this.btnShow3);
            this.Controls.Add(this.btnShow2);
            this.Controls.Add(this.btnShow1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cdSmall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.cdDisplay);
            this.Controls.Add(this.gbPMAlign);
            this.Controls.Add(this.gbImageAcq);
            this.Name = "PMAlign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PMAlign";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PMAlign_FormClosing);
            this.Load += new System.EventHandler(this.PMAlign_Load);
            this.gbImageAcq.ResumeLayout(false);
            this.gbPMAlign.ResumeLayout(false);
            this.gbPMAlign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbImageAcq;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.RadioButton rbImageFile;
        private System.Windows.Forms.RadioButton rbFrameGrabber;
        internal System.Windows.Forms.GroupBox gbPMAlign;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtbScore;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnSetup;
        internal Cognex.VisionPro.Display.CogDisplay cdDisplay;
        internal System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal Cognex.VisionPro.Display.CogDisplay cdSmall;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnShow1;
        private System.Windows.Forms.Button btnShow2;
        private System.Windows.Forms.Button btnShow3;
        private System.Windows.Forms.Button btnShow4;
        internal Cognex.VisionPro.Display.CogDisplay cogDisplay1;
    }
}