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
            this.gbPMAlignResult = new System.Windows.Forms.GroupBox();
            this.cboxShowFeatures = new System.Windows.Forms.CheckBox();
            this.txtbScore = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lbTrain = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.gbPMAlign = new System.Windows.Forms.GroupBox();
            this.txtbScaleHigh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbScaleLow = new System.Windows.Forms.TextBox();
            this.txtbAngleHigh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbAngleLow = new System.Windows.Forms.TextBox();
            this.cboxScoreUsingClutter = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbAcceptThreshold = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numudNumberToFind = new System.Windows.Forms.NumericUpDown();
            this.cboxIgnorePolarity = new System.Windows.Forms.CheckBox();
            this.btnSetup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbEdgeThreshold = new System.Windows.Forms.TextBox();
            this.tpBlob = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbImageAcq = new System.Windows.Forms.GroupBox();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.rbImageFile = new System.Windows.Forms.RadioButton();
            this.rbFrameGrabber = new System.Windows.Forms.RadioButton();
            this.cdDisplay = new Cognex.VisionPro.Display.CogDisplay();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.cbCamList = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.cdPatternTrain = new Cognex.VisionPro.Display.CogDisplay();
            this.gbControlTool = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lboxModel = new System.Windows.Forms.ListBox();
            this.tcPattern.SuspendLayout();
            this.tpPMAlign.SuspendLayout();
            this.gbPMAlignResult.SuspendLayout();
            this.gbPMAlign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudNumberToFind)).BeginInit();
            this.gbImageAcq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdDisplay)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.pnContent.SuspendLayout();
            this.pnFooter.SuspendLayout();
            this.pnDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdPatternTrain)).BeginInit();
            this.gbControlTool.SuspendLayout();
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
            this.tcPattern.Size = new System.Drawing.Size(522, 674);
            this.tcPattern.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcPattern.TabIndex = 0;
            // 
            // tpPMAlign
            // 
            this.tpPMAlign.Controls.Add(this.gbPMAlignResult);
            this.tpPMAlign.Controls.Add(this.gbPMAlign);
            this.tpPMAlign.Location = new System.Drawing.Point(4, 34);
            this.tpPMAlign.Name = "tpPMAlign";
            this.tpPMAlign.Padding = new System.Windows.Forms.Padding(3);
            this.tpPMAlign.Size = new System.Drawing.Size(514, 636);
            this.tpPMAlign.TabIndex = 0;
            this.tpPMAlign.Text = "PMAlign";
            this.tpPMAlign.UseVisualStyleBackColor = true;
            // 
            // gbPMAlignResult
            // 
            this.gbPMAlignResult.Controls.Add(this.cboxShowFeatures);
            this.gbPMAlignResult.Controls.Add(this.txtbScore);
            this.gbPMAlignResult.Controls.Add(this.Label1);
            this.gbPMAlignResult.Controls.Add(this.lbTrain);
            this.gbPMAlignResult.Controls.Add(this.btnRun);
            this.gbPMAlignResult.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPMAlignResult.Location = new System.Drawing.Point(259, 37);
            this.gbPMAlignResult.Name = "gbPMAlignResult";
            this.gbPMAlignResult.Size = new System.Drawing.Size(160, 281);
            this.gbPMAlignResult.TabIndex = 8;
            this.gbPMAlignResult.TabStop = false;
            this.gbPMAlignResult.Text = "PMAlign Result";
            // 
            // cboxShowFeatures
            // 
            this.cboxShowFeatures.AutoSize = true;
            this.cboxShowFeatures.Checked = true;
            this.cboxShowFeatures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxShowFeatures.Location = new System.Drawing.Point(20, 43);
            this.cboxShowFeatures.Name = "cboxShowFeatures";
            this.cboxShowFeatures.Size = new System.Drawing.Size(109, 18);
            this.cboxShowFeatures.TabIndex = 11;
            this.cboxShowFeatures.Text = "Show Features";
            this.cboxShowFeatures.UseVisualStyleBackColor = true;
            // 
            // txtbScore
            // 
            this.txtbScore.Location = new System.Drawing.Point(62, 69);
            this.txtbScore.Multiline = true;
            this.txtbScore.Name = "txtbScore";
            this.txtbScore.Size = new System.Drawing.Size(54, 20);
            this.txtbScore.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 71);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(40, 17);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Score";
            // 
            // lbTrain
            // 
            this.lbTrain.AutoSize = true;
            this.lbTrain.Location = new System.Drawing.Point(16, 23);
            this.lbTrain.Name = "lbTrain";
            this.lbTrain.Size = new System.Drawing.Size(69, 14);
            this.lbTrain.TabIndex = 0;
            this.lbTrain.Text = "Not Trained";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(25, 213);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(104, 48);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // gbPMAlign
            // 
            this.gbPMAlign.Controls.Add(this.txtbScaleHigh);
            this.gbPMAlign.Controls.Add(this.label6);
            this.gbPMAlign.Controls.Add(this.txtbScaleLow);
            this.gbPMAlign.Controls.Add(this.txtbAngleHigh);
            this.gbPMAlign.Controls.Add(this.label5);
            this.gbPMAlign.Controls.Add(this.txtbAngleLow);
            this.gbPMAlign.Controls.Add(this.cboxScoreUsingClutter);
            this.gbPMAlign.Controls.Add(this.label4);
            this.gbPMAlign.Controls.Add(this.txtbAcceptThreshold);
            this.gbPMAlign.Controls.Add(this.label3);
            this.gbPMAlign.Controls.Add(this.numudNumberToFind);
            this.gbPMAlign.Controls.Add(this.cboxIgnorePolarity);
            this.gbPMAlign.Controls.Add(this.btnSetup);
            this.gbPMAlign.Controls.Add(this.label2);
            this.gbPMAlign.Controls.Add(this.txtbEdgeThreshold);
            this.gbPMAlign.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPMAlign.Location = new System.Drawing.Point(19, 37);
            this.gbPMAlign.Name = "gbPMAlign";
            this.gbPMAlign.Size = new System.Drawing.Size(199, 281);
            this.gbPMAlign.TabIndex = 6;
            this.gbPMAlign.TabStop = false;
            this.gbPMAlign.Text = "PMAlign Tool Setup";
            // 
            // txtbScaleHigh
            // 
            this.txtbScaleHigh.Location = new System.Drawing.Point(133, 181);
            this.txtbScaleHigh.Name = "txtbScaleHigh";
            this.txtbScaleHigh.Size = new System.Drawing.Size(53, 20);
            this.txtbScaleHigh.TabIndex = 21;
            this.txtbScaleHigh.Text = "1.2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 14);
            this.label6.TabIndex = 19;
            this.label6.Text = "Scale";
            // 
            // txtbScaleLow
            // 
            this.txtbScaleLow.Location = new System.Drawing.Point(64, 181);
            this.txtbScaleLow.Name = "txtbScaleLow";
            this.txtbScaleLow.Size = new System.Drawing.Size(53, 20);
            this.txtbScaleLow.TabIndex = 20;
            this.txtbScaleLow.Text = "0.8";
            // 
            // txtbAngleHigh
            // 
            this.txtbAngleHigh.Location = new System.Drawing.Point(133, 152);
            this.txtbAngleHigh.Name = "txtbAngleHigh";
            this.txtbAngleHigh.Size = new System.Drawing.Size(53, 20);
            this.txtbAngleHigh.TabIndex = 18;
            this.txtbAngleHigh.Text = "0.25";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Angle :";
            // 
            // txtbAngleLow
            // 
            this.txtbAngleLow.Location = new System.Drawing.Point(64, 152);
            this.txtbAngleLow.Name = "txtbAngleLow";
            this.txtbAngleLow.Size = new System.Drawing.Size(53, 20);
            this.txtbAngleLow.TabIndex = 17;
            this.txtbAngleLow.Text = "-0.25";
            // 
            // cboxScoreUsingClutter
            // 
            this.cboxScoreUsingClutter.AutoSize = true;
            this.cboxScoreUsingClutter.Checked = true;
            this.cboxScoreUsingClutter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxScoreUsingClutter.Location = new System.Drawing.Point(11, 43);
            this.cboxScoreUsingClutter.Name = "cboxScoreUsingClutter";
            this.cboxScoreUsingClutter.Size = new System.Drawing.Size(133, 18);
            this.cboxScoreUsingClutter.TabIndex = 15;
            this.cboxScoreUsingClutter.Text = "Score Using Clutter";
            this.cboxScoreUsingClutter.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Accept Threshold :";
            // 
            // txtbAcceptThreshold
            // 
            this.txtbAcceptThreshold.Location = new System.Drawing.Point(133, 126);
            this.txtbAcceptThreshold.Name = "txtbAcceptThreshold";
            this.txtbAcceptThreshold.Size = new System.Drawing.Size(53, 20);
            this.txtbAcceptThreshold.TabIndex = 14;
            this.txtbAcceptThreshold.Text = "0.5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number To Find :";
            // 
            // numudNumberToFind
            // 
            this.numudNumberToFind.Location = new System.Drawing.Point(133, 97);
            this.numudNumberToFind.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numudNumberToFind.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numudNumberToFind.Name = "numudNumberToFind";
            this.numudNumberToFind.Size = new System.Drawing.Size(53, 20);
            this.numudNumberToFind.TabIndex = 11;
            this.numudNumberToFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numudNumberToFind.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboxIgnorePolarity
            // 
            this.cboxIgnorePolarity.AutoSize = true;
            this.cboxIgnorePolarity.Checked = true;
            this.cboxIgnorePolarity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxIgnorePolarity.Location = new System.Drawing.Point(11, 19);
            this.cboxIgnorePolarity.Name = "cboxIgnorePolarity";
            this.cboxIgnorePolarity.Size = new System.Drawing.Size(106, 18);
            this.cboxIgnorePolarity.TabIndex = 10;
            this.cboxIgnorePolarity.Text = "Ignore Polarity";
            this.cboxIgnorePolarity.UseVisualStyleBackColor = true;
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(48, 213);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(96, 48);
            this.btnSetup.TabIndex = 0;
            this.btnSetup.Text = "Setup";
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "EdgeThreshold :";
            // 
            // txtbEdgeThreshold
            // 
            this.txtbEdgeThreshold.Location = new System.Drawing.Point(133, 68);
            this.txtbEdgeThreshold.Name = "txtbEdgeThreshold";
            this.txtbEdgeThreshold.Size = new System.Drawing.Size(53, 20);
            this.txtbEdgeThreshold.TabIndex = 9;
            this.txtbEdgeThreshold.Text = "10";
            // 
            // tpBlob
            // 
            this.tpBlob.Location = new System.Drawing.Point(4, 34);
            this.tpBlob.Name = "tpBlob";
            this.tpBlob.Padding = new System.Windows.Forms.Padding(3);
            this.tpBlob.Size = new System.Drawing.Size(514, 636);
            this.tpBlob.TabIndex = 1;
            this.tpBlob.Text = "Blob";
            this.tpBlob.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Magenta;
            this.btnClose.Location = new System.Drawing.Point(1059, 12);
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
            this.gbImageAcq.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cdDisplay.Location = new System.Drawing.Point(18, 15);
            this.cdDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdDisplay.MouseWheelSensitivity = 1D;
            this.cdDisplay.Name = "cdDisplay";
            this.cdDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdDisplay.OcxState")));
            this.cdDisplay.Size = new System.Drawing.Size(396, 457);
            this.cdDisplay.TabIndex = 5;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnHeader.Controls.Add(this.cbCamList);
            this.pnHeader.Controls.Add(this.label63);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1206, 43);
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
            this.pnContent.Size = new System.Drawing.Size(522, 674);
            this.pnContent.TabIndex = 2;
            // 
            // pnFooter
            // 
            this.pnFooter.BackColor = System.Drawing.Color.DimGray;
            this.pnFooter.Controls.Add(this.btnClose);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 729);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(1206, 72);
            this.pnFooter.TabIndex = 3;
            // 
            // pnDisplay
            // 
            this.pnDisplay.Controls.Add(this.cdPatternTrain);
            this.pnDisplay.Controls.Add(this.gbControlTool);
            this.pnDisplay.Controls.Add(this.lboxModel);
            this.pnDisplay.Controls.Add(this.gbImageAcq);
            this.pnDisplay.Controls.Add(this.cdDisplay);
            this.pnDisplay.Location = new System.Drawing.Point(524, 49);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(674, 674);
            this.pnDisplay.TabIndex = 4;
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
            this.cdPatternTrain.Location = new System.Drawing.Point(420, 255);
            this.cdPatternTrain.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdPatternTrain.MouseWheelSensitivity = 1D;
            this.cdPatternTrain.Name = "cdPatternTrain";
            this.cdPatternTrain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdPatternTrain.OcxState")));
            this.cdPatternTrain.Size = new System.Drawing.Size(219, 213);
            this.cdPatternTrain.TabIndex = 11;
            // 
            // gbControlTool
            // 
            this.gbControlTool.Controls.Add(this.btnClear);
            this.gbControlTool.Controls.Add(this.btnSave);
            this.gbControlTool.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControlTool.Location = new System.Drawing.Point(432, 491);
            this.gbControlTool.Name = "gbControlTool";
            this.gbControlTool.Size = new System.Drawing.Size(207, 123);
            this.gbControlTool.TabIndex = 10;
            this.gbControlTool.TabStop = false;
            this.gbControlTool.Text = "Control Tool";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(91, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 28);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lboxModel
            // 
            this.lboxModel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxModel.FormattingEnabled = true;
            this.lboxModel.ItemHeight = 14;
            this.lboxModel.Location = new System.Drawing.Point(420, 21);
            this.lboxModel.Name = "lboxModel";
            this.lboxModel.Size = new System.Drawing.Size(219, 228);
            this.lboxModel.TabIndex = 9;
            // 
            // frmPattern
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1206, 801);
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
            this.gbPMAlignResult.ResumeLayout(false);
            this.gbPMAlignResult.PerformLayout();
            this.gbPMAlign.ResumeLayout(false);
            this.gbPMAlign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudNumberToFind)).EndInit();
            this.gbImageAcq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cdDisplay)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.pnContent.ResumeLayout(false);
            this.pnFooter.ResumeLayout(false);
            this.pnDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cdPatternTrain)).EndInit();
            this.gbControlTool.ResumeLayout(false);
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
        internal System.Windows.Forms.GroupBox gbControlTool;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTrain;
        internal Cognex.VisionPro.Display.CogDisplay cdPatternTrain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbEdgeThreshold;
        private System.Windows.Forms.CheckBox cboxIgnorePolarity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numudNumberToFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbAcceptThreshold;
        private System.Windows.Forms.CheckBox cboxScoreUsingClutter;
        private System.Windows.Forms.TextBox txtbAngleHigh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbAngleLow;
        private System.Windows.Forms.TextBox txtbScaleHigh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbScaleLow;
        private System.Windows.Forms.GroupBox gbPMAlignResult;
        private System.Windows.Forms.CheckBox cboxShowFeatures;
        public System.Windows.Forms.ListBox lboxModel;
    }
}