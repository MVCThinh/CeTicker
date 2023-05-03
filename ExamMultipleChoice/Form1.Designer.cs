namespace ExamMultipleChoice
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnDapAn = new System.Windows.Forms.Panel();
            this.chkD = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.wbQuestion = new System.Windows.Forms.WebBrowser();
            this.flpListQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.paLogin = new System.Windows.Forms.Panel();
            this.chkOnline = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCatCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnDapAn.SuspendLayout();
            this.panel3.SuspendLayout();
            this.paLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flpListQuestion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.paLogin, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 724);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pnDapAn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.wbQuestion, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(405, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(941, 614);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pnDapAn
            // 
            this.pnDapAn.Controls.Add(this.chkD);
            this.pnDapAn.Controls.Add(this.btnSave);
            this.pnDapAn.Controls.Add(this.btnFinish);
            this.pnDapAn.Controls.Add(this.btnNextQuestion);
            this.pnDapAn.Controls.Add(this.chkC);
            this.pnDapAn.Controls.Add(this.chkB);
            this.pnDapAn.Controls.Add(this.chkA);
            this.pnDapAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDapAn.Location = new System.Drawing.Point(3, 571);
            this.pnDapAn.Name = "pnDapAn";
            this.pnDapAn.Size = new System.Drawing.Size(935, 40);
            this.pnDapAn.TabIndex = 0;
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.Font = new System.Drawing.Font("Tahoma", 15F);
            this.chkD.Location = new System.Drawing.Point(366, 6);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(113, 28);
            this.chkD.TabIndex = 200;
            this.chkD.Text = "Đáp án D";
            this.chkD.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(500, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Enabled = false;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(828, 3);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(104, 34);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "Nộp bài";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Enabled = false;
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.Location = new System.Drawing.Point(605, 3);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(98, 34);
            this.btnNextQuestion.TabIndex = 2;
            this.btnNextQuestion.Text = "Next >>";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Font = new System.Drawing.Font("Tahoma", 15F);
            this.chkC.Location = new System.Drawing.Point(249, 6);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(111, 28);
            this.chkC.TabIndex = 201;
            this.chkC.Text = "Đáp án C";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.Font = new System.Drawing.Font("Tahoma", 15F);
            this.chkB.Location = new System.Drawing.Point(132, 6);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(111, 28);
            this.chkB.TabIndex = 202;
            this.chkB.Text = "Đáp án B";
            this.chkB.UseVisualStyleBackColor = true;
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.Font = new System.Drawing.Font("Tahoma", 15F);
            this.chkA.Location = new System.Drawing.Point(13, 6);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(111, 28);
            this.chkA.TabIndex = 203;
            this.chkA.Text = "Đáp án A";
            this.chkA.UseVisualStyleBackColor = true;
            // 
            // wbQuestion
            // 
            this.wbQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbQuestion.Location = new System.Drawing.Point(3, 3);
            this.wbQuestion.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbQuestion.Name = "wbQuestion";
            this.wbQuestion.Size = new System.Drawing.Size(935, 562);
            this.wbQuestion.TabIndex = 1;
            // 
            // flpListQuestion
            // 
            this.flpListQuestion.AutoScroll = true;
            this.flpListQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListQuestion.Location = new System.Drawing.Point(405, 625);
            this.flpListQuestion.Name = "flpListQuestion";
            this.flpListQuestion.Size = new System.Drawing.Size(941, 95);
            this.flpListQuestion.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblUserInfo);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 394);
            this.panel3.TabIndex = 4;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.Red;
            this.lblUserInfo.Location = new System.Drawing.Point(0, 357);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(394, 37);
            this.lblUserInfo.TabIndex = 5;
            this.lblUserInfo.Text = "Bạn chưa đăng nhập";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 87);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(391, 270);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Bạn đã trả lời\r\n0/0";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(394, 87);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paLogin
            // 
            this.paLogin.Controls.Add(this.chkOnline);
            this.paLogin.Controls.Add(this.btnStart);
            this.paLogin.Controls.Add(this.btnLogin);
            this.paLogin.Controls.Add(this.txtPass);
            this.paLogin.Controls.Add(this.label3);
            this.paLogin.Controls.Add(this.txtCatCode);
            this.paLogin.Controls.Add(this.label5);
            this.paLogin.Controls.Add(this.txtUser);
            this.paLogin.Controls.Add(this.label1);
            this.paLogin.Location = new System.Drawing.Point(4, 405);
            this.paLogin.Name = "paLogin";
            this.tableLayoutPanel1.SetRowSpan(this.paLogin, 2);
            this.paLogin.Size = new System.Drawing.Size(394, 315);
            this.paLogin.TabIndex = 4;
            // 
            // chkOnline
            // 
            this.chkOnline.AutoSize = true;
            this.chkOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnline.Location = new System.Drawing.Point(166, 91);
            this.chkOnline.Name = "chkOnline";
            this.chkOnline.Size = new System.Drawing.Size(94, 30);
            this.chkOnline.TabIndex = 2;
            this.chkOnline.Text = "Online";
            this.chkOnline.UseVisualStyleBackColor = true;
            this.chkOnline.CheckedChanged += new System.EventHandler(this.chkOnline_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(3, 256);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(388, 54);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Bắt đầu làm bài";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(3, 127);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(388, 61);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(166, 53);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(225, 32);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu";
            // 
            // txtCatCode
            // 
            this.txtCatCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCatCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatCode.Location = new System.Drawing.Point(111, 218);
            this.txtCatCode.Name = "txtCatCode";
            this.txtCatCode.Size = new System.Drawing.Size(280, 32);
            this.txtCatCode.TabIndex = 4;
            this.txtCatCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã kỳ thi";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(166, 14);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(225, 32);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 724);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐÁNH GIÁ NĂNG LỰC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnDapAn.ResumeLayout(false);
            this.pnDapAn.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.paLogin.ResumeLayout(false);
            this.paLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnDapAn;
        private System.Windows.Forms.CheckBox chkD;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.WebBrowser wbQuestion;
        private System.Windows.Forms.FlowLayoutPanel flpListQuestion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel paLogin;
        private System.Windows.Forms.CheckBox chkOnline;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCatCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
    }
}

