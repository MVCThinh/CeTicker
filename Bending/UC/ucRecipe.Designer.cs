namespace Bending.UC
{
    partial class ucRecipe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRecipe));
            this.label63 = new System.Windows.Forms.Label();
            this.cbCamList = new System.Windows.Forms.ComboBox();
            this.cogDS1 = new Cognex.VisionPro.Display.CogDisplay();
            this.cogDS2 = new Cognex.VisionPro.Display.CogDisplay();
            this.tmrCal = new System.Windows.Forms.Timer(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cogDSPattern = new Cognex.VisionPro.Display.CogDisplay();
            this.listPattern = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRecognition = new System.Windows.Forms.Button();
            this.btnLiveCamera = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.frmPatMax = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatMaxScoreValue = new System.Windows.Forms.TextBox();
            this.cmdPatMaxRunCommand = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.gbLight2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.gbParametter = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAngleHigh = new System.Windows.Forms.TextBox();
            this.btnDeletePattern = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAngleLow = new System.Windows.Forms.TextBox();
            this.txtPatternContrastThreshold = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScoreLimit = new System.Windows.Forms.TextBox();
            this.pnCalib = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.gbLight1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLightSave2 = new System.Windows.Forms.Button();
            this.lblContrast2 = new System.Windows.Forms.Label();
            this.lbExposure2 = new System.Windows.Forms.Label();
            this.lbLight2 = new System.Windows.Forms.Label();
            this.txtLight2 = new System.Windows.Forms.TextBox();
            this.tbTrace = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.cogDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDS2)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogDSPattern)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.frmPatMax.SuspendLayout();
            this.gbLight2.SuspendLayout();
            this.gbParametter.SuspendLayout();
            this.pnCalib.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbLight1.SuspendLayout();
            this.tbTrace.SuspendLayout();
            this.SuspendLayout();
            // 
            // label63
            // 
            this.label63.BackColor = System.Drawing.Color.Black;
            this.label63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label63.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label63.ForeColor = System.Drawing.Color.White;
            this.label63.Location = new System.Drawing.Point(0, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(1242, 35);
            this.label63.TabIndex = 84;
            this.label63.Text = "Camera View";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCamList
            // 
            this.cbCamList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbCamList.FormattingEnabled = true;
            this.cbCamList.Location = new System.Drawing.Point(96, 4);
            this.cbCamList.Name = "cbCamList";
            this.cbCamList.Size = new System.Drawing.Size(157, 28);
            this.cbCamList.TabIndex = 85;
            this.cbCamList.SelectedIndexChanged += new System.EventHandler(this.cbCamList_SelectedIndexChanged);
            // 
            // cogDS1
            // 
            this.cogDS1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDS1.ColorMapLowerRoiLimit = 0D;
            this.cogDS1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDS1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDS1.ColorMapUpperRoiLimit = 1D;
            this.cogDS1.DoubleTapZoomCycleLength = 2;
            this.cogDS1.DoubleTapZoomSensitivity = 2.5D;
            this.cogDS1.Location = new System.Drawing.Point(3, 161);
            this.cogDS1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDS1.MouseWheelSensitivity = 1D;
            this.cogDS1.Name = "cogDS1";
            this.cogDS1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDS1.OcxState")));
            this.cogDS1.Size = new System.Drawing.Size(620, 526);
            this.cogDS1.TabIndex = 298;
            // 
            // cogDS2
            // 
            this.cogDS2.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDS2.ColorMapLowerRoiLimit = 0D;
            this.cogDS2.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDS2.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDS2.ColorMapUpperRoiLimit = 1D;
            this.cogDS2.DoubleTapZoomCycleLength = 2;
            this.cogDS2.DoubleTapZoomSensitivity = 2.5D;
            this.cogDS2.Location = new System.Drawing.Point(625, 161);
            this.cogDS2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDS2.MouseWheelSensitivity = 1D;
            this.cogDS2.Name = "cogDS2";
            this.cogDS2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDS2.OcxState")));
            this.cogDS2.Size = new System.Drawing.Size(620, 526);
            this.cogDS2.TabIndex = 299;
            // 
            // tmrCal
            // 
            this.tmrCal.Interval = 300;
            this.tmrCal.Tick += new System.EventHandler(this.tmrCal_Tick);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Black;
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.ImageIndex = 5;
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(652, 862);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Vision";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cogDSPattern);
            this.groupBox4.Controls.Add(this.listPattern);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.frmPatMax);
            this.groupBox4.Controls.Add(this.gbLight2);
            this.groupBox4.Controls.Add(this.gbParametter);
            this.groupBox4.Controls.Add(this.pnCalib);
            this.groupBox4.Controls.Add(this.gbLight1);
            this.groupBox4.Location = new System.Drawing.Point(2, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(625, 837);
            this.groupBox4.TabIndex = 307;
            this.groupBox4.TabStop = false;
            // 
            // cogDSPattern
            // 
            this.cogDSPattern.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDSPattern.ColorMapLowerRoiLimit = 0D;
            this.cogDSPattern.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDSPattern.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDSPattern.ColorMapUpperRoiLimit = 1D;
            this.cogDSPattern.DoubleTapZoomCycleLength = 2;
            this.cogDSPattern.DoubleTapZoomSensitivity = 2.5D;
            this.cogDSPattern.Location = new System.Drawing.Point(48, 602);
            this.cogDSPattern.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDSPattern.MouseWheelSensitivity = 1D;
            this.cogDSPattern.Name = "cogDSPattern";
            this.cogDSPattern.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDSPattern.OcxState")));
            this.cogDSPattern.Size = new System.Drawing.Size(223, 191);
            this.cogDSPattern.TabIndex = 300;
            this.cogDSPattern.Visible = false;
            // 
            // listPattern
            // 
            this.listPattern.BackColor = System.Drawing.Color.Black;
            this.listPattern.ForeColor = System.Drawing.Color.Yellow;
            this.listPattern.FormattingEnabled = true;
            this.listPattern.ItemHeight = 15;
            this.listPattern.Location = new System.Drawing.Point(382, 468);
            this.listPattern.Name = "listPattern";
            this.listPattern.Size = new System.Drawing.Size(244, 109);
            this.listPattern.TabIndex = 315;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRecognition);
            this.groupBox3.Controls.Add(this.btnLiveCamera);
            this.groupBox3.Controls.Add(this.btnCapture);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 458);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 119);
            this.groupBox3.TabIndex = 314;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operator";
            // 
            // btnRecognition
            // 
            this.btnRecognition.BackColor = System.Drawing.Color.White;
            this.btnRecognition.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnRecognition.FlatAppearance.BorderSize = 2;
            this.btnRecognition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRecognition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRecognition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecognition.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecognition.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRecognition.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecognition.Location = new System.Drawing.Point(108, 67);
            this.btnRecognition.Name = "btnRecognition";
            this.btnRecognition.Size = new System.Drawing.Size(101, 40);
            this.btnRecognition.TabIndex = 149;
            this.btnRecognition.Text = "Recognition";
            this.btnRecognition.UseVisualStyleBackColor = false;
            // 
            // btnLiveCamera
            // 
            this.btnLiveCamera.BackColor = System.Drawing.Color.White;
            this.btnLiveCamera.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnLiveCamera.FlatAppearance.BorderSize = 2;
            this.btnLiveCamera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLiveCamera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLiveCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiveCamera.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiveCamera.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLiveCamera.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLiveCamera.Location = new System.Drawing.Point(6, 25);
            this.btnLiveCamera.Name = "btnLiveCamera";
            this.btnLiveCamera.Size = new System.Drawing.Size(89, 82);
            this.btnLiveCamera.TabIndex = 51;
            this.btnLiveCamera.Text = "Live Camera";
            this.btnLiveCamera.UseVisualStyleBackColor = false;
            this.btnLiveCamera.Click += new System.EventHandler(this.btnLiveCamera_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.White;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCapture.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapture.Location = new System.Drawing.Point(108, 25);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(101, 40);
            this.btnCapture.TabIndex = 291;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // frmPatMax
            // 
            this.frmPatMax.Controls.Add(this.label5);
            this.frmPatMax.Controls.Add(this.txtPatMaxScoreValue);
            this.frmPatMax.Controls.Add(this.cmdPatMaxRunCommand);
            this.frmPatMax.Controls.Add(this.btnSetup);
            this.frmPatMax.ForeColor = System.Drawing.Color.White;
            this.frmPatMax.Location = new System.Drawing.Point(6, 334);
            this.frmPatMax.Name = "frmPatMax";
            this.frmPatMax.Size = new System.Drawing.Size(360, 102);
            this.frmPatMax.TabIndex = 313;
            this.frmPatMax.TabStop = false;
            this.frmPatMax.Text = "Pattern Search";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(192, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Score";
            // 
            // txtPatMaxScoreValue
            // 
            this.txtPatMaxScoreValue.Location = new System.Drawing.Point(246, 39);
            this.txtPatMaxScoreValue.Multiline = true;
            this.txtPatMaxScoreValue.Name = "txtPatMaxScoreValue";
            this.txtPatMaxScoreValue.Size = new System.Drawing.Size(70, 37);
            this.txtPatMaxScoreValue.TabIndex = 2;
            // 
            // cmdPatMaxRunCommand
            // 
            this.cmdPatMaxRunCommand.ForeColor = System.Drawing.Color.White;
            this.cmdPatMaxRunCommand.Location = new System.Drawing.Point(89, 39);
            this.cmdPatMaxRunCommand.Name = "cmdPatMaxRunCommand";
            this.cmdPatMaxRunCommand.Size = new System.Drawing.Size(85, 37);
            this.cmdPatMaxRunCommand.TabIndex = 1;
            this.cmdPatMaxRunCommand.Text = "Run";
            // 
            // btnSetup
            // 
            this.btnSetup.ForeColor = System.Drawing.Color.White;
            this.btnSetup.Location = new System.Drawing.Point(8, 40);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 36);
            this.btnSetup.TabIndex = 0;
            this.btnSetup.Text = "Setup";
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // gbLight2
            // 
            this.gbLight2.Controls.Add(this.textBox3);
            this.gbLight2.Controls.Add(this.textBox4);
            this.gbLight2.Controls.Add(this.button3);
            this.gbLight2.Controls.Add(this.label1);
            this.gbLight2.Controls.Add(this.label2);
            this.gbLight2.Controls.Add(this.label4);
            this.gbLight2.Controls.Add(this.textBox5);
            this.gbLight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbLight2.ForeColor = System.Drawing.Color.Cyan;
            this.gbLight2.Location = new System.Drawing.Point(198, 175);
            this.gbLight2.Name = "gbLight2";
            this.gbLight2.Size = new System.Drawing.Size(151, 153);
            this.gbLight2.TabIndex = 312;
            this.gbLight2.TabStop = false;
            this.gbLight2.Text = "Light 2";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(81, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 22);
            this.textBox3.TabIndex = 329;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(81, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(46, 22);
            this.textBox4.TabIndex = 328;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(34, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 33);
            this.button3.TabIndex = 322;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 291;
            this.label1.Text = "Contrast";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 286;
            this.label2.Text = "Exposure";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 258;
            this.label4.Text = "Light";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5.Location = new System.Drawing.Point(81, 25);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(46, 22);
            this.textBox5.TabIndex = 259;
            // 
            // gbParametter
            // 
            this.gbParametter.BackColor = System.Drawing.SystemColors.Control;
            this.gbParametter.Controls.Add(this.button2);
            this.gbParametter.Controls.Add(this.txtAngleHigh);
            this.gbParametter.Controls.Add(this.btnDeletePattern);
            this.gbParametter.Controls.Add(this.label13);
            this.gbParametter.Controls.Add(this.label24);
            this.gbParametter.Controls.Add(this.txtAngleLow);
            this.gbParametter.Controls.Add(this.txtPatternContrastThreshold);
            this.gbParametter.Controls.Add(this.label3);
            this.gbParametter.Controls.Add(this.txtScoreLimit);
            this.gbParametter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbParametter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParametter.Location = new System.Drawing.Point(3, 10);
            this.gbParametter.Name = "gbParametter";
            this.gbParametter.Padding = new System.Windows.Forms.Padding(5);
            this.gbParametter.Size = new System.Drawing.Size(376, 159);
            this.gbParametter.TabIndex = 311;
            this.gbParametter.TabStop = false;
            this.gbParametter.Text = "Parametter";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(82, 121);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 29);
            this.button2.TabIndex = 257;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = false;
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
            // btnDeletePattern
            // 
            this.btnDeletePattern.BackColor = System.Drawing.Color.White;
            this.btnDeletePattern.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnDeletePattern.FlatAppearance.BorderSize = 2;
            this.btnDeletePattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePattern.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePattern.Location = new System.Drawing.Point(158, 121);
            this.btnDeletePattern.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePattern.Name = "btnDeletePattern";
            this.btnDeletePattern.Size = new System.Drawing.Size(68, 29);
            this.btnDeletePattern.TabIndex = 256;
            this.btnDeletePattern.Text = "Reset";
            this.btnDeletePattern.UseVisualStyleBackColor = false;
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
            // pnCalib
            // 
            this.pnCalib.BackColor = System.Drawing.Color.DimGray;
            this.pnCalib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCalib.Controls.Add(this.dataGridView1);
            this.pnCalib.Controls.Add(this.button1);
            this.pnCalib.Location = new System.Drawing.Point(381, 6);
            this.pnCalib.Name = "pnCalib";
            this.pnCalib.Size = new System.Drawing.Size(244, 449);
            this.pnCalib.TabIndex = 310;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(242, 168);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Points";
            this.Column1.Name = "Column1";
            this.Column1.Width = 66;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Robot";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Vision";
            this.Column3.Name = "Column3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calibration";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbLight1
            // 
            this.gbLight1.Controls.Add(this.textBox2);
            this.gbLight1.Controls.Add(this.textBox1);
            this.gbLight1.Controls.Add(this.btnLightSave2);
            this.gbLight1.Controls.Add(this.lblContrast2);
            this.gbLight1.Controls.Add(this.lbExposure2);
            this.gbLight1.Controls.Add(this.lbLight2);
            this.gbLight1.Controls.Add(this.txtLight2);
            this.gbLight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbLight1.ForeColor = System.Drawing.Color.Cyan;
            this.gbLight1.Location = new System.Drawing.Point(4, 173);
            this.gbLight1.Name = "gbLight1";
            this.gbLight1.Size = new System.Drawing.Size(151, 153);
            this.gbLight1.TabIndex = 297;
            this.gbLight1.TabStop = false;
            this.gbLight1.Text = "Light 1";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(81, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 22);
            this.textBox2.TabIndex = 329;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(81, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 22);
            this.textBox1.TabIndex = 328;
            // 
            // btnLightSave2
            // 
            this.btnLightSave2.BackColor = System.Drawing.Color.White;
            this.btnLightSave2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLightSave2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLightSave2.Location = new System.Drawing.Point(34, 114);
            this.btnLightSave2.Name = "btnLightSave2";
            this.btnLightSave2.Size = new System.Drawing.Size(63, 33);
            this.btnLightSave2.TabIndex = 322;
            this.btnLightSave2.Text = "Save";
            this.btnLightSave2.UseVisualStyleBackColor = false;
            // 
            // lblContrast2
            // 
            this.lblContrast2.BackColor = System.Drawing.Color.Black;
            this.lblContrast2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContrast2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrast2.ForeColor = System.Drawing.Color.Linen;
            this.lblContrast2.Location = new System.Drawing.Point(3, 84);
            this.lblContrast2.Name = "lblContrast2";
            this.lblContrast2.Size = new System.Drawing.Size(70, 21);
            this.lblContrast2.TabIndex = 291;
            this.lblContrast2.Text = "Contrast";
            this.lblContrast2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbExposure2
            // 
            this.lbExposure2.BackColor = System.Drawing.Color.Black;
            this.lbExposure2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbExposure2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExposure2.ForeColor = System.Drawing.Color.Linen;
            this.lbExposure2.Location = new System.Drawing.Point(3, 56);
            this.lbExposure2.Name = "lbExposure2";
            this.lbExposure2.Size = new System.Drawing.Size(70, 21);
            this.lbExposure2.TabIndex = 286;
            this.lbExposure2.Text = "Exposure";
            this.lbExposure2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLight2
            // 
            this.lbLight2.BackColor = System.Drawing.Color.Black;
            this.lbLight2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLight2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLight2.ForeColor = System.Drawing.Color.Linen;
            this.lbLight2.Location = new System.Drawing.Point(3, 26);
            this.lbLight2.Name = "lbLight2";
            this.lbLight2.Size = new System.Drawing.Size(70, 21);
            this.lbLight2.TabIndex = 258;
            this.lbLight2.Text = "Light";
            this.lbLight2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLight2
            // 
            this.txtLight2.BackColor = System.Drawing.Color.White;
            this.txtLight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLight2.Location = new System.Drawing.Point(81, 25);
            this.txtLight2.Name = "txtLight2";
            this.txtLight2.Size = new System.Drawing.Size(46, 22);
            this.txtLight2.TabIndex = 259;
            // 
            // tbTrace
            // 
            this.tbTrace.Controls.Add(this.tabPage5);
            this.tbTrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbTrace.Location = new System.Drawing.Point(1241, 0);
            this.tbTrace.Name = "tbTrace";
            this.tbTrace.SelectedIndex = 0;
            this.tbTrace.Size = new System.Drawing.Size(660, 890);
            this.tbTrace.TabIndex = 297;
            // 
            // ucRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.cogDS2);
            this.Controls.Add(this.cogDS1);
            this.Controls.Add(this.tbTrace);
            this.Controls.Add(this.cbCamList);
            this.Controls.Add(this.label63);
            this.Name = "ucRecipe";
            this.Size = new System.Drawing.Size(1913, 823);
            ((System.ComponentModel.ISupportInitialize)(this.cogDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDS2)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogDSPattern)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.frmPatMax.ResumeLayout(false);
            this.frmPatMax.PerformLayout();
            this.gbLight2.ResumeLayout(false);
            this.gbLight2.PerformLayout();
            this.gbParametter.ResumeLayout(false);
            this.gbParametter.PerformLayout();
            this.pnCalib.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbLight1.ResumeLayout(false);
            this.gbLight1.PerformLayout();
            this.tbTrace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label63;
        private Cognex.VisionPro.Display.CogDisplay cogDS1;
        private Cognex.VisionPro.Display.CogDisplay cogDS2;
        public System.Windows.Forms.Timer tmrCal;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnLiveCamera;
        private System.Windows.Forms.Button btnRecognition;
        private System.Windows.Forms.GroupBox gbLight1;
        public System.Windows.Forms.Label lblContrast2;
        public System.Windows.Forms.Label lbExposure2;
        public System.Windows.Forms.Label lbLight2;
        private System.Windows.Forms.TextBox txtLight2;
        private System.Windows.Forms.TabControl tbTrace;
        private System.Windows.Forms.Panel pnCalib;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbCamList;
        private Cognex.VisionPro.Display.CogDisplay cogDSPattern;
        private System.Windows.Forms.GroupBox gbLight2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox gbParametter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAngleHigh;
        private System.Windows.Forms.Button btnDeletePattern;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtAngleLow;
        private System.Windows.Forms.TextBox txtPatternContrastThreshold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScoreLimit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLightSave2;
        internal System.Windows.Forms.GroupBox frmPatMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPatMaxScoreValue;
        private System.Windows.Forms.Button cmdPatMaxRunCommand;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listPattern;
    }
}
