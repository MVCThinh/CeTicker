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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Display = new Cognex.VisionPro.Display.CogDisplay();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnNextFile = new System.Windows.Forms.Button();
            this.btnCreateRegion = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnTrainPattern = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRunPMAlign = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnSettingUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.lbT = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Display);
            this.panel1.Location = new System.Drawing.Point(540, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 551);
            this.panel1.TabIndex = 0;
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
            this.Display.Size = new System.Drawing.Size(414, 251);
            this.Display.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNextFile);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Location = new System.Drawing.Point(3, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operator";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOpenFile.Location = new System.Drawing.Point(55, 19);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(84, 31);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "OpenFile";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnNextFile
            // 
            this.btnNextFile.Location = new System.Drawing.Point(145, 19);
            this.btnNextFile.Name = "btnNextFile";
            this.btnNextFile.Size = new System.Drawing.Size(84, 31);
            this.btnNextFile.TabIndex = 1;
            this.btnNextFile.Text = "NextFile";
            this.btnNextFile.UseVisualStyleBackColor = true;
            this.btnNextFile.Click += new System.EventHandler(this.btnNextFile_Click);
            // 
            // btnCreateRegion
            // 
            this.btnCreateRegion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateRegion.Location = new System.Drawing.Point(18, 19);
            this.btnCreateRegion.Name = "btnCreateRegion";
            this.btnCreateRegion.Size = new System.Drawing.Size(91, 31);
            this.btnCreateRegion.TabIndex = 2;
            this.btnCreateRegion.Text = "Create Region";
            this.btnCreateRegion.UseVisualStyleBackColor = true;
            this.btnCreateRegion.Click += new System.EventHandler(this.btnCreateRegion_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(208, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "OpenFile";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnTrainPattern
            // 
            this.btnTrainPattern.Location = new System.Drawing.Point(128, 72);
            this.btnTrainPattern.Name = "btnTrainPattern";
            this.btnTrainPattern.Size = new System.Drawing.Size(84, 31);
            this.btnTrainPattern.TabIndex = 4;
            this.btnTrainPattern.Text = "Train Pattern";
            this.btnTrainPattern.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(495, 514);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(487, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PMAlign";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(487, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.groupBox2.Controls.Add(this.btnCreateRegion);
            this.groupBox2.Controls.Add(this.btnTrainPattern);
            this.groupBox2.Controls.Add(this.btnRunPMAlign);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(27, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 149);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnRunPMAlign
            // 
            this.btnRunPMAlign.Location = new System.Drawing.Point(18, 72);
            this.btnRunPMAlign.Name = "btnRunPMAlign";
            this.btnRunPMAlign.Size = new System.Drawing.Size(84, 31);
            this.btnRunPMAlign.TabIndex = 5;
            this.btnRunPMAlign.Text = "Run PMAlign";
            this.btnRunPMAlign.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "OpenFile";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(58, 456);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 45);
            this.button6.TabIndex = 7;
            this.button6.Text = "OpenFile";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnSettingUp
            // 
            this.btnSettingUp.Location = new System.Drawing.Point(128, 19);
            this.btnSettingUp.Name = "btnSettingUp";
            this.btnSettingUp.Size = new System.Drawing.Size(84, 31);
            this.btnSettingUp.TabIndex = 6;
            this.btnSettingUp.Text = "Setting Up";
            this.btnSettingUp.UseVisualStyleBackColor = true;
            this.btnSettingUp.Click += new System.EventHandler(this.btnSettingUp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(113, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 77);
            this.button1.TabIndex = 7;
            this.button1.Text = "OpenFile";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(260, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score : ";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.ForeColor = System.Drawing.Color.Yellow;
            this.lbScore.Location = new System.Drawing.Point(302, 73);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(22, 13);
            this.lbScore.TabIndex = 8;
            this.lbScore.Text = "0.0";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.ForeColor = System.Drawing.Color.Yellow;
            this.lbX.Location = new System.Drawing.Point(260, 99);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(22, 13);
            this.lbX.TabIndex = 9;
            this.lbX.Text = "0.0";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.ForeColor = System.Drawing.Color.Yellow;
            this.lbY.Location = new System.Drawing.Point(302, 99);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(22, 13);
            this.lbY.TabIndex = 10;
            this.lbY.Text = "0.0";
            // 
            // lbT
            // 
            this.lbT.AutoSize = true;
            this.lbT.ForeColor = System.Drawing.Color.Yellow;
            this.lbT.Location = new System.Drawing.Point(345, 99);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(22, 13);
            this.lbT.TabIndex = 11;
            this.lbT.Text = "0.0";
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 587);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateRegion;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnTrainPattern;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNextFile;
        private System.Windows.Forms.Button btnOpenFile;
        private Cognex.VisionPro.Display.CogDisplay Display;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRunPMAlign;
        private System.Windows.Forms.Button btnSettingUp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbT;
    }
}