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
            this.cdDisplay1 = new Cognex.VisionPro.Display.CogDisplay();
            this.cdDisplay2 = new Cognex.VisionPro.Display.CogDisplay();
            this.pnRunVision = new System.Windows.Forms.Panel();
            this.pnListModel = new System.Windows.Forms.Panel();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.btnLoadModel = new System.Windows.Forms.Button();
            this.lboxModel = new System.Windows.Forms.ListBox();
            this.pnCalib = new System.Windows.Forms.Panel();
            this.lbStatusCalib = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCalib = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalibration = new System.Windows.Forms.Button();
            this.pnControlAndResult = new System.Windows.Forms.Panel();
            this.gbRunResult = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbScore = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.gbLight = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbLight4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbLight3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbLight2 = new System.Windows.Forms.TextBox();
            this.lbLight2 = new System.Windows.Forms.Label();
            this.txtbLight1 = new System.Windows.Forms.TextBox();
            this.gbImageAcq = new System.Windows.Forms.GroupBox();
            this.rbImageFile = new System.Windows.Forms.RadioButton();
            this.rbFrameGrabber = new System.Windows.Forms.RadioButton();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cdDisplay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdDisplay2)).BeginInit();
            this.pnRunVision.SuspendLayout();
            this.pnListModel.SuspendLayout();
            this.pnCalib.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalib)).BeginInit();
            this.pnControlAndResult.SuspendLayout();
            this.gbRunResult.SuspendLayout();
            this.gbLight.SuspendLayout();
            this.gbImageAcq.SuspendLayout();
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
            this.label63.Size = new System.Drawing.Size(264, 35);
            this.label63.TabIndex = 84;
            this.label63.Text = "Select Vision";
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
            // 
            // cdDisplay1
            // 
            this.cdDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cdDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cdDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cdDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cdDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cdDisplay1.DoubleTapZoomCycleLength = 2;
            this.cdDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cdDisplay1.Location = new System.Drawing.Point(-1, 161);
            this.cdDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdDisplay1.MouseWheelSensitivity = 1D;
            this.cdDisplay1.Name = "cdDisplay1";
            this.cdDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdDisplay1.OcxState")));
            this.cdDisplay1.Size = new System.Drawing.Size(620, 526);
            this.cdDisplay1.TabIndex = 298;
            // 
            // cdDisplay2
            // 
            this.cdDisplay2.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cdDisplay2.ColorMapLowerRoiLimit = 0D;
            this.cdDisplay2.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cdDisplay2.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cdDisplay2.ColorMapUpperRoiLimit = 1D;
            this.cdDisplay2.DoubleTapZoomCycleLength = 2;
            this.cdDisplay2.DoubleTapZoomSensitivity = 2.5D;
            this.cdDisplay2.Location = new System.Drawing.Point(622, 161);
            this.cdDisplay2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdDisplay2.MouseWheelSensitivity = 1D;
            this.cdDisplay2.Name = "cdDisplay2";
            this.cdDisplay2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdDisplay2.OcxState")));
            this.cdDisplay2.Size = new System.Drawing.Size(620, 526);
            this.cdDisplay2.TabIndex = 299;
            // 
            // pnRunVision
            // 
            this.pnRunVision.Controls.Add(this.pnListModel);
            this.pnRunVision.Controls.Add(this.pnCalib);
            this.pnRunVision.Controls.Add(this.pnControlAndResult);
            this.pnRunVision.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRunVision.Location = new System.Drawing.Point(1248, 0);
            this.pnRunVision.Name = "pnRunVision";
            this.pnRunVision.Size = new System.Drawing.Size(665, 823);
            this.pnRunVision.TabIndex = 315;
            // 
            // pnListModel
            // 
            this.pnListModel.Controls.Add(this.btnRefreshList);
            this.pnListModel.Controls.Add(this.btnLoadModel);
            this.pnListModel.Controls.Add(this.lboxModel);
            this.pnListModel.Location = new System.Drawing.Point(295, 381);
            this.pnListModel.Name = "pnListModel";
            this.pnListModel.Size = new System.Drawing.Size(282, 423);
            this.pnListModel.TabIndex = 335;
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshList.Location = new System.Drawing.Point(8, 360);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(97, 32);
            this.btnRefreshList.TabIndex = 337;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // btnLoadModel
            // 
            this.btnLoadModel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadModel.Location = new System.Drawing.Point(119, 360);
            this.btnLoadModel.Name = "btnLoadModel";
            this.btnLoadModel.Size = new System.Drawing.Size(97, 32);
            this.btnLoadModel.TabIndex = 336;
            this.btnLoadModel.Text = "Load Model";
            this.btnLoadModel.UseVisualStyleBackColor = true;
            this.btnLoadModel.Click += new System.EventHandler(this.btnLoadModel_Click);
            // 
            // lboxModel
            // 
            this.lboxModel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxModel.FormattingEnabled = true;
            this.lboxModel.ItemHeight = 14;
            this.lboxModel.Location = new System.Drawing.Point(3, 3);
            this.lboxModel.Name = "lboxModel";
            this.lboxModel.Size = new System.Drawing.Size(213, 340);
            this.lboxModel.TabIndex = 335;
            // 
            // pnCalib
            // 
            this.pnCalib.BackColor = System.Drawing.Color.DimGray;
            this.pnCalib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCalib.Controls.Add(this.lbStatusCalib);
            this.pnCalib.Controls.Add(this.label5);
            this.pnCalib.Controls.Add(this.dgvCalib);
            this.pnCalib.Controls.Add(this.btnCalibration);
            this.pnCalib.Location = new System.Drawing.Point(3, 380);
            this.pnCalib.Name = "pnCalib";
            this.pnCalib.Size = new System.Drawing.Size(285, 440);
            this.pnCalib.TabIndex = 334;
            // 
            // lbStatusCalib
            // 
            this.lbStatusCalib.AutoSize = true;
            this.lbStatusCalib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusCalib.ForeColor = System.Drawing.Color.Lime;
            this.lbStatusCalib.Location = new System.Drawing.Point(228, 388);
            this.lbStatusCalib.Name = "lbStatusCalib";
            this.lbStatusCalib.Size = new System.Drawing.Size(33, 20);
            this.lbStatusCalib.TabIndex = 4;
            this.lbStatusCalib.Text = "OK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(156, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Status :";
            // 
            // dgvCalib
            // 
            this.dgvCalib.AllowUserToResizeColumns = false;
            this.dgvCalib.AllowUserToResizeRows = false;
            this.dgvCalib.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCalib.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCalib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalib.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCalib.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCalib.Location = new System.Drawing.Point(0, 0);
            this.dgvCalib.Name = "dgvCalib";
            this.dgvCalib.RowHeadersVisible = false;
            this.dgvCalib.Size = new System.Drawing.Size(283, 258);
            this.dgvCalib.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Points";
            this.Column1.Name = "Column1";
            this.Column1.Width = 61;
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
            // btnCalibration
            // 
            this.btnCalibration.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalibration.Location = new System.Drawing.Point(21, 375);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.Size = new System.Drawing.Size(107, 48);
            this.btnCalibration.TabIndex = 0;
            this.btnCalibration.Text = "Calibration";
            this.btnCalibration.UseVisualStyleBackColor = true;
            // 
            // pnControlAndResult
            // 
            this.pnControlAndResult.Controls.Add(this.gbRunResult);
            this.pnControlAndResult.Controls.Add(this.gbLight);
            this.pnControlAndResult.Controls.Add(this.gbImageAcq);
            this.pnControlAndResult.Location = new System.Drawing.Point(3, 4);
            this.pnControlAndResult.Name = "pnControlAndResult";
            this.pnControlAndResult.Size = new System.Drawing.Size(498, 370);
            this.pnControlAndResult.TabIndex = 318;
            // 
            // gbRunResult
            // 
            this.gbRunResult.Controls.Add(this.btnRun);
            this.gbRunResult.Controls.Add(this.label4);
            this.gbRunResult.Controls.Add(this.txtbScore);
            this.gbRunResult.Controls.Add(this.btnSetting);
            this.gbRunResult.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRunResult.ForeColor = System.Drawing.Color.White;
            this.gbRunResult.Location = new System.Drawing.Point(7, 250);
            this.gbRunResult.Name = "gbRunResult";
            this.gbRunResult.Size = new System.Drawing.Size(470, 100);
            this.gbRunResult.TabIndex = 315;
            this.gbRunResult.TabStop = false;
            this.gbRunResult.Text = "Run And Result";
            // 
            // btnRun
            // 
            this.btnRun.AutoSize = true;
            this.btnRun.BackColor = System.Drawing.Color.White;
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnRun.FlatAppearance.BorderSize = 2;
            this.btnRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRun.Location = new System.Drawing.Point(143, 30);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(108, 49);
            this.btnRun.TabIndex = 295;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 294;
            this.label4.Text = "Score :";
            // 
            // txtbScore
            // 
            this.txtbScore.AutoSize = true;
            this.txtbScore.BackColor = System.Drawing.Color.White;
            this.txtbScore.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.txtbScore.FlatAppearance.BorderSize = 2;
            this.txtbScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.txtbScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.txtbScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtbScore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbScore.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbScore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtbScore.Location = new System.Drawing.Point(369, 30);
            this.txtbScore.Name = "txtbScore";
            this.txtbScore.Size = new System.Drawing.Size(83, 49);
            this.txtbScore.TabIndex = 293;
            this.txtbScore.Text = "N/A";
            this.txtbScore.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            this.btnSetting.AutoSize = true;
            this.btnSetting.BackColor = System.Drawing.Color.White;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnSetting.FlatAppearance.BorderSize = 2;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetting.Location = new System.Drawing.Point(17, 30);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(108, 49);
            this.btnSetting.TabIndex = 292;
            this.btnSetting.Text = "SETTING";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // gbLight
            // 
            this.gbLight.Controls.Add(this.label2);
            this.gbLight.Controls.Add(this.txtbLight4);
            this.gbLight.Controls.Add(this.label3);
            this.gbLight.Controls.Add(this.txtbLight3);
            this.gbLight.Controls.Add(this.label1);
            this.gbLight.Controls.Add(this.txtbLight2);
            this.gbLight.Controls.Add(this.lbLight2);
            this.gbLight.Controls.Add(this.txtbLight1);
            this.gbLight.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLight.ForeColor = System.Drawing.Color.White;
            this.gbLight.Location = new System.Drawing.Point(7, 3);
            this.gbLight.Name = "gbLight";
            this.gbLight.Size = new System.Drawing.Size(470, 104);
            this.gbLight.TabIndex = 317;
            this.gbLight.TabStop = false;
            this.gbLight.Text = "Light Setting";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(143, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 264;
            this.label2.Text = "Light 4";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbLight4
            // 
            this.txtbLight4.BackColor = System.Drawing.Color.White;
            this.txtbLight4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbLight4.Location = new System.Drawing.Point(221, 60);
            this.txtbLight4.Name = "txtbLight4";
            this.txtbLight4.Size = new System.Drawing.Size(46, 22);
            this.txtbLight4.TabIndex = 265;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(143, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 262;
            this.label3.Text = "Light 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbLight3
            // 
            this.txtbLight3.BackColor = System.Drawing.Color.White;
            this.txtbLight3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbLight3.Location = new System.Drawing.Point(221, 24);
            this.txtbLight3.Name = "txtbLight3";
            this.txtbLight3.Size = new System.Drawing.Size(46, 22);
            this.txtbLight3.TabIndex = 263;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 260;
            this.label1.Text = "Light 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbLight2
            // 
            this.txtbLight2.BackColor = System.Drawing.Color.White;
            this.txtbLight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbLight2.Location = new System.Drawing.Point(81, 61);
            this.txtbLight2.Name = "txtbLight2";
            this.txtbLight2.Size = new System.Drawing.Size(46, 22);
            this.txtbLight2.TabIndex = 261;
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
            this.lbLight2.Text = "Light 1";
            this.lbLight2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbLight1
            // 
            this.txtbLight1.BackColor = System.Drawing.Color.White;
            this.txtbLight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbLight1.Location = new System.Drawing.Point(81, 25);
            this.txtbLight1.Name = "txtbLight1";
            this.txtbLight1.Size = new System.Drawing.Size(46, 22);
            this.txtbLight1.TabIndex = 259;
            // 
            // gbImageAcq
            // 
            this.gbImageAcq.Controls.Add(this.rbImageFile);
            this.gbImageAcq.Controls.Add(this.rbFrameGrabber);
            this.gbImageAcq.Controls.Add(this.btnNextImage);
            this.gbImageAcq.Controls.Add(this.btnOpenFolder);
            this.gbImageAcq.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImageAcq.ForeColor = System.Drawing.Color.White;
            this.gbImageAcq.Location = new System.Drawing.Point(7, 124);
            this.gbImageAcq.Name = "gbImageAcq";
            this.gbImageAcq.Size = new System.Drawing.Size(470, 100);
            this.gbImageAcq.TabIndex = 314;
            this.gbImageAcq.TabStop = false;
            this.gbImageAcq.Text = "Image Acquisition";
            // 
            // rbImageFile
            // 
            this.rbImageFile.AutoSize = true;
            this.rbImageFile.Checked = true;
            this.rbImageFile.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbImageFile.Location = new System.Drawing.Point(15, 59);
            this.rbImageFile.Name = "rbImageFile";
            this.rbImageFile.Size = new System.Drawing.Size(97, 20);
            this.rbImageFile.TabIndex = 294;
            this.rbImageFile.TabStop = true;
            this.rbImageFile.Text = "Image File";
            this.rbImageFile.UseVisualStyleBackColor = true;
            // 
            // rbFrameGrabber
            // 
            this.rbFrameGrabber.AutoSize = true;
            this.rbFrameGrabber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFrameGrabber.Location = new System.Drawing.Point(15, 29);
            this.rbFrameGrabber.Name = "rbFrameGrabber";
            this.rbFrameGrabber.Size = new System.Drawing.Size(131, 20);
            this.rbFrameGrabber.TabIndex = 293;
            this.rbFrameGrabber.Text = "Frame Grabber";
            this.rbFrameGrabber.UseVisualStyleBackColor = true;
            this.rbFrameGrabber.CheckedChanged += new System.EventHandler(this.rbFrameGrabber_CheckedChanged);
            // 
            // btnNextImage
            // 
            this.btnNextImage.AutoSize = true;
            this.btnNextImage.BackColor = System.Drawing.Color.White;
            this.btnNextImage.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnNextImage.FlatAppearance.BorderSize = 2;
            this.btnNextImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNextImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNextImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextImage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextImage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnNextImage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNextImage.Location = new System.Drawing.Point(341, 29);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(109, 50);
            this.btnNextImage.TabIndex = 292;
            this.btnNextImage.Text = "Next Image";
            this.btnNextImage.UseVisualStyleBackColor = false;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.AutoSize = true;
            this.btnOpenFolder.BackColor = System.Drawing.Color.White;
            this.btnOpenFolder.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnOpenFolder.FlatAppearance.BorderSize = 2;
            this.btnOpenFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOpenFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFolder.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOpenFolder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenFolder.Location = new System.Drawing.Point(191, 29);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(109, 50);
            this.btnOpenFolder.TabIndex = 51;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = false;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // ucRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pnRunVision);
            this.Controls.Add(this.cdDisplay2);
            this.Controls.Add(this.cdDisplay1);
            this.Controls.Add(this.cbCamList);
            this.Controls.Add(this.label63);
            this.Name = "ucRecipe";
            this.Size = new System.Drawing.Size(1913, 823);
            ((System.ComponentModel.ISupportInitialize)(this.cdDisplay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdDisplay2)).EndInit();
            this.pnRunVision.ResumeLayout(false);
            this.pnListModel.ResumeLayout(false);
            this.pnCalib.ResumeLayout(false);
            this.pnCalib.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalib)).EndInit();
            this.pnControlAndResult.ResumeLayout(false);
            this.gbRunResult.ResumeLayout(false);
            this.gbRunResult.PerformLayout();
            this.gbLight.ResumeLayout(false);
            this.gbLight.PerformLayout();
            this.gbImageAcq.ResumeLayout(false);
            this.gbImageAcq.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label63;
        private Cognex.VisionPro.Display.CogDisplay cdDisplay1;
        private Cognex.VisionPro.Display.CogDisplay cdDisplay2;
        private System.Windows.Forms.ComboBox cbCamList;
        private System.Windows.Forms.Panel pnRunVision;
        private System.Windows.Forms.Panel pnControlAndResult;
        private System.Windows.Forms.GroupBox gbRunResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button txtbScore;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.GroupBox gbImageAcq;
        private System.Windows.Forms.RadioButton rbImageFile;
        private System.Windows.Forms.RadioButton rbFrameGrabber;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.GroupBox gbLight;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbLight4;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbLight3;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbLight2;
        public System.Windows.Forms.Label lbLight2;
        private System.Windows.Forms.TextBox txtbLight1;
        private System.Windows.Forms.Panel pnCalib;
        private System.Windows.Forms.Label lbStatusCalib;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCalib;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnCalibration;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Panel pnListModel;
        private System.Windows.Forms.Button btnLoadModel;
        private System.Windows.Forms.ListBox lboxModel;
        private System.Windows.Forms.Button btnRefreshList;
    }
}
