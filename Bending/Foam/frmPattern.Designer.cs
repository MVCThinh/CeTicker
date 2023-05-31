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
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.tcPattern = new System.Windows.Forms.TabControl();
            this.tpPMAlign = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.tpBlob = new System.Windows.Forms.TabPage();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.cbCamList = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbShowDisplay = new System.Windows.Forms.GroupBox();
            this.lbTrain = new System.Windows.Forms.Label();
            this.cboxShowGraphics = new System.Windows.Forms.CheckBox();
            this.cdPatternTrain = new Cognex.VisionPro.Display.CogDisplay();
            this.tcPattern.SuspendLayout();
            this.tpPMAlign.SuspendLayout();
            this.gbImageAcq.SuspendLayout();
            this.gbPMAlign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdDisplay)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.pnContent.SuspendLayout();
            this.pnFooter.SuspendLayout();
            this.pnDisplay.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbShowDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdPatternTrain)).BeginInit();
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
            this.tcPattern.Size = new System.Drawing.Size(737, 674);
            this.tcPattern.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcPattern.TabIndex = 0;
            // 
            // tpPMAlign
            // 
            this.tpPMAlign.Controls.Add(this.gbShowDisplay);
            this.tpPMAlign.Controls.Add(this.gbPMAlign);
            this.tpPMAlign.Location = new System.Drawing.Point(4, 34);
            this.tpPMAlign.Name = "tpPMAlign";
            this.tpPMAlign.Padding = new System.Windows.Forms.Padding(3);
            this.tpPMAlign.Size = new System.Drawing.Size(729, 636);
            this.tpPMAlign.TabIndex = 0;
            this.tpPMAlign.Text = "PMAlign";
            this.tpPMAlign.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Magenta;
            this.btnClose.Location = new System.Drawing.Point(1320, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 48);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbImageAcq
            // 
            this.gbImageAcq.Controls.Add(this.btnNextImage);
            this.gbImageAcq.Controls.Add(this.btnOpenFile);
            this.gbImageAcq.Controls.Add(this.rbImageFile);
            this.gbImageAcq.Controls.Add(this.rbFrameGrabber);
            this.gbImageAcq.Location = new System.Drawing.Point(5, 491);
            this.gbImageAcq.Name = "gbImageAcq";
            this.gbImageAcq.Size = new System.Drawing.Size(421, 123);
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
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(170, 48);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(85, 40);
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
            this.rbFrameGrabber.Size = new System.Drawing.Size(122, 24);
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
            this.gbPMAlign.Location = new System.Drawing.Point(19, 37);
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
            this.cdDisplay.Location = new System.Drawing.Point(21, 12);
            this.cdDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdDisplay.MouseWheelSensitivity = 1D;
            this.cdDisplay.Name = "cdDisplay";
            this.cdDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdDisplay.OcxState")));
            this.cdDisplay.Size = new System.Drawing.Size(405, 457);
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
            this.pnHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnHeader.Controls.Add(this.cbCamList);
            this.pnHeader.Controls.Add(this.label63);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1447, 43);
            this.pnHeader.TabIndex = 1;
            // 
            // cbCamList
            // 
            this.cbCamList.BackColor = System.Drawing.Color.Magenta;
            this.cbCamList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbCamList.ForeColor = System.Drawing.Color.Transparent;
            this.cbCamList.FormattingEnabled = true;
            this.cbCamList.Location = new System.Drawing.Point(104, 8);
            this.cbCamList.Name = "cbCamList";
            this.cbCamList.Size = new System.Drawing.Size(157, 28);
            this.cbCamList.TabIndex = 87;
            // 
            // label63
            // 
            this.label63.BackColor = System.Drawing.Color.Transparent;
            this.label63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label63.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label63.ForeColor = System.Drawing.Color.Magenta;
            this.label63.Location = new System.Drawing.Point(3, 5);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(95, 35);
            this.label63.TabIndex = 86;
            this.label63.Text = "Select Vision";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnContent
            // 
            this.pnContent.Controls.Add(this.tcPattern);
            this.pnContent.Location = new System.Drawing.Point(0, 49);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(737, 674);
            this.pnContent.TabIndex = 2;
            // 
            // pnFooter
            // 
            this.pnFooter.BackColor = System.Drawing.Color.DimGray;
            this.pnFooter.Controls.Add(this.btnClose);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 729);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(1447, 72);
            this.pnFooter.TabIndex = 3;
            // 
            // pnDisplay
            // 
            this.pnDisplay.Controls.Add(this.cdPatternTrain);
            this.pnDisplay.Controls.Add(this.groupBox1);
            this.pnDisplay.Controls.Add(this.listBox1);
            this.pnDisplay.Controls.Add(this.gbImageAcq);
            this.pnDisplay.Controls.Add(this.cdDisplay);
            this.pnDisplay.Location = new System.Drawing.Point(738, 49);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(709, 674);
            this.pnDisplay.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(448, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 228);
            this.listBox1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(432, 491);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 123);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pattern Train";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            // 
            // gbShowDisplay
            // 
            this.gbShowDisplay.Controls.Add(this.cboxShowGraphics);
            this.gbShowDisplay.Controls.Add(this.lbTrain);
            this.gbShowDisplay.Location = new System.Drawing.Point(428, 37);
            this.gbShowDisplay.Name = "gbShowDisplay";
            this.gbShowDisplay.Size = new System.Drawing.Size(259, 128);
            this.gbShowDisplay.TabIndex = 7;
            this.gbShowDisplay.TabStop = false;
            this.gbShowDisplay.Text = "Show Display";
            // 
            // lbTrain
            // 
            this.lbTrain.AutoSize = true;
            this.lbTrain.Location = new System.Drawing.Point(6, 40);
            this.lbTrain.Name = "lbTrain";
            this.lbTrain.Size = new System.Drawing.Size(80, 16);
            this.lbTrain.TabIndex = 0;
            this.lbTrain.Text = "Not Trained";
            // 
            // cboxShowGraphics
            // 
            this.cboxShowGraphics.AutoSize = true;
            this.cboxShowGraphics.Location = new System.Drawing.Point(117, 38);
            this.cboxShowGraphics.Name = "cboxShowGraphics";
            this.cboxShowGraphics.Size = new System.Drawing.Size(122, 20);
            this.cboxShowGraphics.TabIndex = 1;
            this.cboxShowGraphics.Text = "Show Graphics";
            this.cboxShowGraphics.UseVisualStyleBackColor = true;
            this.cboxShowGraphics.CheckedChanged += new System.EventHandler(this.cboxShowGraphics_CheckedChanged);
            // 
            // cdPatternTrain
            // 
            this.cdPatternTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cdPatternTrain.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cdPatternTrain.ColorMapLowerRoiLimit = 0D;
            this.cdPatternTrain.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cdPatternTrain.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cdPatternTrain.ColorMapUpperRoiLimit = 1D;
            this.cdPatternTrain.DoubleTapZoomCycleLength = 2;
            this.cdPatternTrain.DoubleTapZoomSensitivity = 2.5D;
            this.cdPatternTrain.Location = new System.Drawing.Point(448, 256);
            this.cdPatternTrain.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdPatternTrain.MouseWheelSensitivity = 1D;
            this.cdPatternTrain.Name = "cdPatternTrain";
            this.cdPatternTrain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdPatternTrain.OcxState")));
            this.cdPatternTrain.Size = new System.Drawing.Size(249, 213);
            this.cdPatternTrain.TabIndex = 11;
            // 
            // frmPattern
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1447, 801);
            this.Controls.Add(this.pnDisplay);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnHeader);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPattern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pattern Register";
            this.tcPattern.ResumeLayout(false);
            this.tpPMAlign.ResumeLayout(false);
            this.gbImageAcq.ResumeLayout(false);
            this.gbPMAlign.ResumeLayout(false);
            this.gbPMAlign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdDisplay)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.pnContent.ResumeLayout(false);
            this.pnFooter.ResumeLayout(false);
            this.pnDisplay.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbShowDisplay.ResumeLayout(false);
            this.gbShowDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdPatternTrain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFD;
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
        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.Panel pnDisplay;
        internal System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        internal System.Windows.Forms.GroupBox gbShowDisplay;
        private System.Windows.Forms.CheckBox cboxShowGraphics;
        private System.Windows.Forms.Label lbTrain;
        internal Cognex.VisionPro.Display.CogDisplay cdPatternTrain;
    }
}