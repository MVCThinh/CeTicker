namespace Bending.Foam
{
    partial class frmPattern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPattern));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tcPattern = new System.Windows.Forms.TabControl();
            this.tpPMAlign = new System.Windows.Forms.TabPage();
            this.gbPMAlign = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtbScore = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.cdDisplay = new Cognex.VisionPro.Display.CogDisplay();
            this.tpBlob = new System.Windows.Forms.TabPage();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnContent = new System.Windows.Forms.Panel();
            this.cbCamList = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.gbImageAcq = new System.Windows.Forms.GroupBox();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.rbImageFile = new System.Windows.Forms.RadioButton();
            this.rbFrameGrabber = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.tcPattern.SuspendLayout();
            this.tpPMAlign.SuspendLayout();
            this.gbPMAlign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdDisplay)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.pnContent.SuspendLayout();
            this.gbImageAcq.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPattern
            // 
            this.tcPattern.Controls.Add(this.tpPMAlign);
            this.tcPattern.Controls.Add(this.tpBlob);
            this.tcPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPattern.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcPattern.ItemSize = new System.Drawing.Size(100, 30);
            this.tcPattern.Location = new System.Drawing.Point(0, 0);
            this.tcPattern.Name = "tcPattern";
            this.tcPattern.SelectedIndex = 0;
            this.tcPattern.ShowToolTips = true;
            this.tcPattern.Size = new System.Drawing.Size(1128, 720);
            this.tcPattern.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcPattern.TabIndex = 0;
            // 
            // tpPMAlign
            // 
            this.tpPMAlign.Controls.Add(this.btnClose);
            this.tpPMAlign.Controls.Add(this.gbImageAcq);
            this.tpPMAlign.Controls.Add(this.gbPMAlign);
            this.tpPMAlign.Controls.Add(this.cdDisplay);
            this.tpPMAlign.Location = new System.Drawing.Point(4, 34);
            this.tpPMAlign.Name = "tpPMAlign";
            this.tpPMAlign.Padding = new System.Windows.Forms.Padding(3);
            this.tpPMAlign.Size = new System.Drawing.Size(1120, 682);
            this.tpPMAlign.TabIndex = 0;
            this.tpPMAlign.Text = "PMAlign";
            this.tpPMAlign.UseVisualStyleBackColor = true;
            // 
            // gbPMAlign
            // 
            this.gbPMAlign.Controls.Add(this.Label1);
            this.gbPMAlign.Controls.Add(this.txtbScore);
            this.gbPMAlign.Controls.Add(this.btnRun);
            this.gbPMAlign.Controls.Add(this.btnSetup);
            this.gbPMAlign.Location = new System.Drawing.Point(33, 223);
            this.gbPMAlign.Name = "gbPMAlign";
            this.gbPMAlign.Size = new System.Drawing.Size(392, 128);
            this.gbPMAlign.TabIndex = 6;
            this.gbPMAlign.TabStop = false;
            this.gbPMAlign.Text = "PMAlign Tool";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(232, 56);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 32);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Score";
            // 
            // txtbScore
            // 
            this.txtbScore.Location = new System.Drawing.Point(296, 40);
            this.txtbScore.Multiline = true;
            this.txtbScore.Name = "txtbScore";
            this.txtbScore.Size = new System.Drawing.Size(80, 40);
            this.txtbScore.TabIndex = 2;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(112, 40);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(104, 48);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(8, 40);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(96, 48);
            this.btnSetup.TabIndex = 0;
            this.btnSetup.Text = "Setup";
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
            this.cdDisplay.Location = new System.Drawing.Point(636, 6);
            this.cdDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdDisplay.MouseWheelSensitivity = 1D;
            this.cdDisplay.Name = "cdDisplay";
            this.cdDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdDisplay.OcxState")));
            this.cdDisplay.Size = new System.Drawing.Size(442, 493);
            this.cdDisplay.TabIndex = 5;
            // 
            // tpBlob
            // 
            this.tpBlob.Location = new System.Drawing.Point(4, 34);
            this.tpBlob.Name = "tpBlob";
            this.tpBlob.Padding = new System.Windows.Forms.Padding(3);
            this.tpBlob.Size = new System.Drawing.Size(1120, 682);
            this.tpBlob.TabIndex = 1;
            this.tpBlob.Text = "Blob";
            this.tpBlob.UseVisualStyleBackColor = true;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.White;
            this.pnHeader.Controls.Add(this.cbCamList);
            this.pnHeader.Controls.Add(this.label63);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1128, 43);
            this.pnHeader.TabIndex = 1;
            // 
            // pnContent
            // 
            this.pnContent.Controls.Add(this.tcPattern);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnContent.Location = new System.Drawing.Point(0, 42);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1128, 720);
            this.pnContent.TabIndex = 2;
            // 
            // cbCamList
            // 
            this.cbCamList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbCamList.FormattingEnabled = true;
            this.cbCamList.Location = new System.Drawing.Point(104, 8);
            this.cbCamList.Name = "cbCamList";
            this.cbCamList.Size = new System.Drawing.Size(157, 28);
            this.cbCamList.TabIndex = 87;
            // 
            // label63
            // 
            this.label63.BackColor = System.Drawing.Color.DimGray;
            this.label63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label63.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label63.ForeColor = System.Drawing.Color.White;
            this.label63.Location = new System.Drawing.Point(3, 5);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(1121, 35);
            this.label63.TabIndex = 86;
            this.label63.Text = "Select Vision";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbImageAcq
            // 
            this.gbImageAcq.Controls.Add(this.btnNextImage);
            this.gbImageAcq.Controls.Add(this.btnOpenFile);
            this.gbImageAcq.Controls.Add(this.rbImageFile);
            this.gbImageAcq.Controls.Add(this.rbFrameGrabber);
            this.gbImageAcq.Location = new System.Drawing.Point(33, 47);
            this.gbImageAcq.Name = "gbImageAcq";
            this.gbImageAcq.Size = new System.Drawing.Size(392, 123);
            this.gbImageAcq.TabIndex = 7;
            this.gbImageAcq.TabStop = false;
            this.gbImageAcq.Text = "Image Acquisition";
            // 
            // btnNextImage
            // 
            this.btnNextImage.Location = new System.Drawing.Point(280, 48);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(96, 40);
            this.btnNextImage.TabIndex = 3;
            this.btnNextImage.Text = "Next Image";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(170, 48);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(85, 40);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open File";
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
            this.rbFrameGrabber.Size = new System.Drawing.Size(122, 24);
            this.rbFrameGrabber.TabIndex = 0;
            this.rbFrameGrabber.Text = "Frame Grabber";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(826, 572);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 48);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPattern
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1128, 762);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnHeader);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPattern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pattern Register";
            this.tcPattern.ResumeLayout(false);
            this.tpPMAlign.ResumeLayout(false);
            this.gbPMAlign.ResumeLayout(false);
            this.gbPMAlign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdDisplay)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.pnContent.ResumeLayout(false);
            this.gbImageAcq.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tcPattern;
        private System.Windows.Forms.TabPage tpPMAlign;
        private System.Windows.Forms.TabPage tpBlob;
        internal Cognex.VisionPro.Display.CogDisplay cdDisplay;
        internal System.Windows.Forms.GroupBox gbPMAlign;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtbScore;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.ComboBox cbCamList;
        public System.Windows.Forms.Label label63;
        internal System.Windows.Forms.GroupBox gbImageAcq;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.RadioButton rbImageFile;
        private System.Windows.Forms.RadioButton rbFrameGrabber;
        private System.Windows.Forms.Button btnClose;
    }
}