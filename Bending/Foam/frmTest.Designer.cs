namespace Bending.Foam
{
    partial class frmTest
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node5", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node4", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node8", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node7", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node10", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node12", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNextFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.Display = new Cognex.VisionPro.Display.CogDisplay();
            this.btnTrainPattern = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbT = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSettingUp = new System.Windows.Forms.Button();
            this.btnRunPMAlign = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lboxPattern = new System.Windows.Forms.ListBox();
            this.cdPattern = new Cognex.VisionPro.Display.CogDisplay();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.PreInspectDispStatusBar = new Cognex.VisionPro.CogDisplayStatusBarV2();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdPattern)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PreInspectDispStatusBar);
            this.panel1.Controls.Add(this.lboxPattern);
            this.panel1.Controls.Add(this.cdPattern);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Display);
            this.panel1.Location = new System.Drawing.Point(479, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 551);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnNextFile);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Location = new System.Drawing.Point(21, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operator";
            // 
            // btnNextFile
            // 
            this.btnNextFile.Location = new System.Drawing.Point(18, 75);
            this.btnNextFile.Name = "btnNextFile";
            this.btnNextFile.Size = new System.Drawing.Size(84, 31);
            this.btnNextFile.TabIndex = 1;
            this.btnNextFile.Text = "NextFile";
            this.btnNextFile.UseVisualStyleBackColor = true;
            this.btnNextFile.Click += new System.EventHandler(this.btnNextFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOpenFile.Location = new System.Drawing.Point(18, 38);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(84, 31);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "OpenFile";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // Display
            // 
            this.Display.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.Display.ColorMapLowerRoiLimit = 0D;
            this.Display.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.Display.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.Display.ColorMapUpperRoiLimit = 1D;
            this.Display.DoubleTapZoomCycleLength = 2;
            this.Display.DoubleTapZoomSensitivity = 2.5D;
            this.Display.Location = new System.Drawing.Point(3, 3);
            this.Display.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.Display.MouseWheelSensitivity = 1D;
            this.Display.Name = "Display";
            this.Display.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Display.OcxState")));
            this.Display.Size = new System.Drawing.Size(414, 212);
            this.Display.TabIndex = 3;
            // 
            // btnTrainPattern
            // 
            this.btnTrainPattern.Location = new System.Drawing.Point(176, 19);
            this.btnTrainPattern.Name = "btnTrainPattern";
            this.btnTrainPattern.Size = new System.Drawing.Size(84, 31);
            this.btnTrainPattern.TabIndex = 4;
            this.btnTrainPattern.Text = "Train Pattern";
            this.btnTrainPattern.UseVisualStyleBackColor = true;
            this.btnTrainPattern.Click += new System.EventHandler(this.btnTrainPattern_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(452, 514);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(444, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PMAlign";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.lbT);
            this.groupBox2.Controls.Add(this.lbY);
            this.groupBox2.Controls.Add(this.lbX);
            this.groupBox2.Controls.Add(this.lbScore);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSettingUp);
            this.groupBox2.Controls.Add(this.btnTrainPattern);
            this.groupBox2.Controls.Add(this.btnRunPMAlign);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(19, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 149);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lbT
            // 
            this.lbT.AutoSize = true;
            this.lbT.ForeColor = System.Drawing.Color.Yellow;
            this.lbT.Location = new System.Drawing.Point(113, 121);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(22, 13);
            this.lbT.TabIndex = 11;
            this.lbT.Text = "0.0";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.ForeColor = System.Drawing.Color.Yellow;
            this.lbY.Location = new System.Drawing.Point(173, 119);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(22, 13);
            this.lbY.TabIndex = 10;
            this.lbY.Text = "0.0";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.ForeColor = System.Drawing.Color.Yellow;
            this.lbX.Location = new System.Drawing.Point(52, 121);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(22, 13);
            this.lbX.TabIndex = 9;
            this.lbX.Text = "0.0";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.ForeColor = System.Drawing.Color.Yellow;
            this.lbScore.Location = new System.Drawing.Point(305, 121);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(22, 13);
            this.lbScore.TabIndex = 8;
            this.lbScore.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(239, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score : ";
            // 
            // btnSettingUp
            // 
            this.btnSettingUp.Location = new System.Drawing.Point(18, 19);
            this.btnSettingUp.Name = "btnSettingUp";
            this.btnSettingUp.Size = new System.Drawing.Size(84, 31);
            this.btnSettingUp.TabIndex = 6;
            this.btnSettingUp.Text = "Setting Up";
            this.btnSettingUp.UseVisualStyleBackColor = true;
            this.btnSettingUp.Click += new System.EventHandler(this.btnSettingUp_Click);
            // 
            // btnRunPMAlign
            // 
            this.btnRunPMAlign.Location = new System.Drawing.Point(176, 66);
            this.btnRunPMAlign.Name = "btnRunPMAlign";
            this.btnRunPMAlign.Size = new System.Drawing.Size(84, 31);
            this.btnRunPMAlign.TabIndex = 5;
            this.btnRunPMAlign.Text = "Run PMAlign";
            this.btnRunPMAlign.UseVisualStyleBackColor = true;
            this.btnRunPMAlign.Click += new System.EventHandler(this.btnRunPMAlign_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(444, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(925, 24);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node6";
            treeNode1.Text = "Node6";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Node5";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Node4";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Node0";
            treeNode5.Name = "Node9";
            treeNode5.Text = "Node9";
            treeNode6.Name = "Node8";
            treeNode6.Text = "Node8";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Node1";
            treeNode9.Name = "Node11";
            treeNode9.Text = "Node11";
            treeNode10.Name = "Node10";
            treeNode10.Text = "Node10";
            treeNode11.Name = "Node2";
            treeNode11.Text = "Node2";
            treeNode12.Name = "Node13";
            treeNode12.Text = "Node13";
            treeNode13.Name = "Node12";
            treeNode13.Text = "Node12";
            treeNode14.Name = "Node3";
            treeNode14.Text = "Node3";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode11,
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(164, 225);
            this.treeView1.TabIndex = 8;
            // 
            // lboxPattern
            // 
            this.lboxPattern.FormattingEnabled = true;
            this.lboxPattern.Location = new System.Drawing.Point(226, 265);
            this.lboxPattern.Name = "lboxPattern";
            this.lboxPattern.Size = new System.Drawing.Size(156, 108);
            this.lboxPattern.TabIndex = 9;
            // 
            // cdPattern
            // 
            this.cdPattern.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cdPattern.ColorMapLowerRoiLimit = 0D;
            this.cdPattern.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cdPattern.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cdPattern.ColorMapUpperRoiLimit = 1D;
            this.cdPattern.DoubleTapZoomCycleLength = 2;
            this.cdPattern.DoubleTapZoomSensitivity = 2.5D;
            this.cdPattern.Location = new System.Drawing.Point(21, 260);
            this.cdPattern.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdPattern.MouseWheelSensitivity = 1D;
            this.cdPattern.Name = "cdPattern";
            this.cdPattern.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdPattern.OcxState")));
            this.cdPattern.Size = new System.Drawing.Size(184, 113);
            this.cdPattern.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save Pattern";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(125, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 31);
            this.button5.TabIndex = 3;
            this.button5.Text = "Clear Pattern";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // PreInspectDispStatusBar
            // 
            this.PreInspectDispStatusBar.CoordinateSpaceName = "*\\#";
            this.PreInspectDispStatusBar.CoordinateSpaceName3D = "*\\#";
            this.PreInspectDispStatusBar.Location = new System.Drawing.Point(39, 221);
            this.PreInspectDispStatusBar.Name = "PreInspectDispStatusBar";
            this.PreInspectDispStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PreInspectDispStatusBar.Size = new System.Drawing.Size(336, 21);
            this.PreInspectDispStatusBar.TabIndex = 11;
            this.PreInspectDispStatusBar.Use3DCoordinateSpaceTree = false;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 587);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdPattern)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTrainPattern;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNextFile;
        private System.Windows.Forms.Button btnOpenFile;
        private Cognex.VisionPro.Display.CogDisplay Display;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRunPMAlign;
        private System.Windows.Forms.Button btnSettingUp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbT;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox lboxPattern;
        private Cognex.VisionPro.Display.CogDisplay cdPattern;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        internal Cognex.VisionPro.CogDisplayStatusBarV2 PreInspectDispStatusBar;
    }
}