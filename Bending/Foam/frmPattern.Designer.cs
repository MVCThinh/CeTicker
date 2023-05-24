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
            this.cogDisplay = new Cognex.VisionPro.Display.CogDisplay();
            this.lbBottom = new System.Windows.Forms.Panel();
            this.cboCamName = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.listPattern = new System.Windows.Forms.ListBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAngleHigh = new System.Windows.Forms.TextBox();
            this.txtAngleLow = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPatternContrastThreshold = new System.Windows.Forms.TextBox();
            this.txtScoreLimit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeletePattern = new System.Windows.Forms.Button();
            this.frmImageAcquisitionFrame = new System.Windows.Forms.GroupBox();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.optImageAcquisitionOptionImageFile = new System.Windows.Forms.RadioButton();
            this.optImageAcquisitionOptionFrameGrabber = new System.Windows.Forms.RadioButton();
            this.frmPatMax = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtPatMaxScoreValue = new System.Windows.Forms.TextBox();
            this.cmdPatMaxRunCommand = new System.Windows.Forms.Button();
            this.cmdPatMaxSetupCommand = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay)).BeginInit();
            this.lbBottom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.frmImageAcquisitionFrame.SuspendLayout();
            this.frmPatMax.SuspendLayout();
            this.SuspendLayout();
            // 
            // cogDisplay
            // 
            this.cogDisplay.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay.DoubleTapZoomCycleLength = 2;
            this.cogDisplay.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay.Location = new System.Drawing.Point(453, 45);
            this.cogDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay.MouseWheelSensitivity = 1D;
            this.cogDisplay.Name = "cogDisplay";
            this.cogDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay.OcxState")));
            this.cogDisplay.Size = new System.Drawing.Size(560, 420);
            this.cogDisplay.TabIndex = 2;
            // 
            // lbBottom
            // 
            this.lbBottom.BackColor = System.Drawing.Color.LightSlateGray;
            this.lbBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBottom.Controls.Add(this.cboCamName);
            this.lbBottom.Controls.Add(this.label14);
            this.lbBottom.Location = new System.Drawing.Point(0, 0);
            this.lbBottom.Name = "lbBottom";
            this.lbBottom.Size = new System.Drawing.Size(1135, 39);
            this.lbBottom.TabIndex = 228;
            // 
            // cboCamName
            // 
            this.cboCamName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboCamName.FormattingEnabled = true;
            this.cboCamName.Location = new System.Drawing.Point(127, 6);
            this.cboCamName.Name = "cboCamName";
            this.cboCamName.Size = new System.Drawing.Size(173, 28);
            this.cboCamName.TabIndex = 225;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(3, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 33);
            this.label14.TabIndex = 65;
            this.label14.Text = "Cam Select :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listPattern
            // 
            this.listPattern.BackColor = System.Drawing.Color.Black;
            this.listPattern.ForeColor = System.Drawing.Color.Yellow;
            this.listPattern.FormattingEnabled = true;
            this.listPattern.Location = new System.Drawing.Point(539, 471);
            this.listPattern.Name = "listPattern";
            this.listPattern.Size = new System.Drawing.Size(414, 121);
            this.listPattern.TabIndex = 251;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(22, 71);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 22);
            this.label24.TabIndex = 237;
            this.label24.Text = "Angle (Low)";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAngleHigh
            // 
            this.txtAngleHigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAngleHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAngleHigh.Location = new System.Drawing.Point(236, 72);
            this.txtAngleHigh.Name = "txtAngleHigh";
            this.txtAngleHigh.Size = new System.Drawing.Size(64, 22);
            this.txtAngleHigh.TabIndex = 232;
            this.txtAngleHigh.Text = "2";
            // 
            // txtAngleLow
            // 
            this.txtAngleLow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAngleLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAngleLow.Location = new System.Drawing.Point(126, 72);
            this.txtAngleLow.Name = "txtAngleLow";
            this.txtAngleLow.Size = new System.Drawing.Size(64, 22);
            this.txtAngleLow.TabIndex = 231;
            this.txtAngleLow.Text = "-2";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(22, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 22);
            this.label13.TabIndex = 104;
            this.label13.Text = "Threshold";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatternContrastThreshold
            // 
            this.txtPatternContrastThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatternContrastThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPatternContrastThreshold.Location = new System.Drawing.Point(103, 36);
            this.txtPatternContrastThreshold.Name = "txtPatternContrastThreshold";
            this.txtPatternContrastThreshold.Size = new System.Drawing.Size(64, 22);
            this.txtPatternContrastThreshold.TabIndex = 105;
            this.txtPatternContrastThreshold.Text = "10";
            // 
            // txtScoreLimit
            // 
            this.txtScoreLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScoreLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtScoreLimit.Location = new System.Drawing.Point(282, 37);
            this.txtScoreLimit.Name = "txtScoreLimit";
            this.txtScoreLimit.Size = new System.Drawing.Size(64, 22);
            this.txtScoreLimit.TabIndex = 107;
            this.txtScoreLimit.Text = "0.7";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(195, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 106;
            this.label3.Text = "ScoreLimit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtAngleHigh);
            this.groupBox1.Controls.Add(this.btnDeletePattern);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtAngleLow);
            this.groupBox1.Controls.Add(this.txtPatternContrastThreshold);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtScoreLimit);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(385, 159);
            this.groupBox1.TabIndex = 257;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametter";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(61, 111);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 29);
            this.button2.TabIndex = 257;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnDeletePattern
            // 
            this.btnDeletePattern.BackColor = System.Drawing.Color.White;
            this.btnDeletePattern.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnDeletePattern.FlatAppearance.BorderSize = 2;
            this.btnDeletePattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePattern.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePattern.Location = new System.Drawing.Point(153, 111);
            this.btnDeletePattern.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePattern.Name = "btnDeletePattern";
            this.btnDeletePattern.Size = new System.Drawing.Size(68, 29);
            this.btnDeletePattern.TabIndex = 256;
            this.btnDeletePattern.Text = "Reset";
            this.btnDeletePattern.UseVisualStyleBackColor = false;
            // 
            // frmImageAcquisitionFrame
            // 
            this.frmImageAcquisitionFrame.Controls.Add(this.btnNextImage);
            this.frmImageAcquisitionFrame.Controls.Add(this.btnOpenFile);
            this.frmImageAcquisitionFrame.Controls.Add(this.optImageAcquisitionOptionImageFile);
            this.frmImageAcquisitionFrame.Controls.Add(this.optImageAcquisitionOptionFrameGrabber);
            this.frmImageAcquisitionFrame.Location = new System.Drawing.Point(26, 90);
            this.frmImageAcquisitionFrame.Name = "frmImageAcquisitionFrame";
            this.frmImageAcquisitionFrame.Size = new System.Drawing.Size(384, 136);
            this.frmImageAcquisitionFrame.TabIndex = 260;
            this.frmImageAcquisitionFrame.TabStop = false;
            this.frmImageAcquisitionFrame.Text = "Image Acquisition";
            // 
            // btnNextImage
            // 
            this.btnNextImage.Location = new System.Drawing.Point(250, 48);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(75, 40);
            this.btnNextImage.TabIndex = 3;
            this.btnNextImage.Text = "Next Image";
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
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
            // optImageAcquisitionOptionImageFile
            // 
            this.optImageAcquisitionOptionImageFile.Checked = true;
            this.optImageAcquisitionOptionImageFile.Location = new System.Drawing.Point(24, 64);
            this.optImageAcquisitionOptionImageFile.Name = "optImageAcquisitionOptionImageFile";
            this.optImageAcquisitionOptionImageFile.Size = new System.Drawing.Size(104, 24);
            this.optImageAcquisitionOptionImageFile.TabIndex = 1;
            this.optImageAcquisitionOptionImageFile.TabStop = true;
            this.optImageAcquisitionOptionImageFile.Text = "Image File";
            this.optImageAcquisitionOptionImageFile.CheckedChanged += new System.EventHandler(this.ImageAcquisitionOption_CheckedChanged);
            // 
            // optImageAcquisitionOptionFrameGrabber
            // 
            this.optImageAcquisitionOptionFrameGrabber.Location = new System.Drawing.Point(24, 32);
            this.optImageAcquisitionOptionFrameGrabber.Name = "optImageAcquisitionOptionFrameGrabber";
            this.optImageAcquisitionOptionFrameGrabber.Size = new System.Drawing.Size(104, 24);
            this.optImageAcquisitionOptionFrameGrabber.TabIndex = 0;
            this.optImageAcquisitionOptionFrameGrabber.Text = "Frame Grabber";
            this.optImageAcquisitionOptionFrameGrabber.CheckedChanged += new System.EventHandler(this.ImageAcquisitionOption_CheckedChanged);
            // 
            // frmPatMax
            // 
            this.frmPatMax.Controls.Add(this.Label1);
            this.frmPatMax.Controls.Add(this.txtPatMaxScoreValue);
            this.frmPatMax.Controls.Add(this.cmdPatMaxRunCommand);
            this.frmPatMax.Controls.Add(this.cmdPatMaxSetupCommand);
            this.frmPatMax.Location = new System.Drawing.Point(26, 421);
            this.frmPatMax.Name = "frmPatMax";
            this.frmPatMax.Size = new System.Drawing.Size(392, 128);
            this.frmPatMax.TabIndex = 261;
            this.frmPatMax.TabStop = false;
            this.frmPatMax.Text = "Pattern Search";
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
            // cmdPatMaxRunCommand
            // 
            this.cmdPatMaxRunCommand.Location = new System.Drawing.Point(112, 40);
            this.cmdPatMaxRunCommand.Name = "cmdPatMaxRunCommand";
            this.cmdPatMaxRunCommand.Size = new System.Drawing.Size(104, 48);
            this.cmdPatMaxRunCommand.TabIndex = 1;
            this.cmdPatMaxRunCommand.Text = "Run";
            // 
            // cmdPatMaxSetupCommand
            // 
            this.cmdPatMaxSetupCommand.Location = new System.Drawing.Point(8, 40);
            this.cmdPatMaxSetupCommand.Name = "cmdPatMaxSetupCommand";
            this.cmdPatMaxSetupCommand.Size = new System.Drawing.Size(96, 48);
            this.cmdPatMaxSetupCommand.TabIndex = 0;
            this.cmdPatMaxSetupCommand.Text = "Setup";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 48);
            this.button1.TabIndex = 262;
            this.button1.Text = "Save Pattern";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(151, 555);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 48);
            this.button3.TabIndex = 263;
            this.button3.Text = "Close";
            // 
            // frmPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 723);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.frmPatMax);
            this.Controls.Add(this.frmImageAcquisitionFrame);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listPattern);
            this.Controls.Add(this.lbBottom);
            this.Controls.Add(this.cogDisplay);
            this.Name = "frmPattern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPattern";
            this.Load += new System.EventHandler(this.frmPattern_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay)).EndInit();
            this.lbBottom.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.frmImageAcquisitionFrame.ResumeLayout(false);
            this.frmPatMax.ResumeLayout(false);
            this.frmPatMax.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Cognex.VisionPro.Display.CogDisplay cogDisplay;
        private System.Windows.Forms.Panel lbBottom;
        private System.Windows.Forms.ComboBox cboCamName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listPattern;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtAngleHigh;
        private System.Windows.Forms.TextBox txtAngleLow;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPatternContrastThreshold;
        private System.Windows.Forms.TextBox txtScoreLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeletePattern;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.GroupBox frmImageAcquisitionFrame;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.RadioButton optImageAcquisitionOptionImageFile;
        private System.Windows.Forms.RadioButton optImageAcquisitionOptionFrameGrabber;
        internal System.Windows.Forms.GroupBox frmPatMax;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtPatMaxScoreValue;
        private System.Windows.Forms.Button cmdPatMaxRunCommand;
        private System.Windows.Forms.Button cmdPatMaxSetupCommand;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}