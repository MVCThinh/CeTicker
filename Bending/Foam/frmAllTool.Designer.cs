namespace Bending.Foam
{
    partial class frmAllTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllTool));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PreInspectDisplay = new Cognex.VisionPro.Display.CogDisplay();
            this.PreInspectDispStatusBar = new Cognex.VisionPro.CogDisplayStatusBarV2();
            this.PostInspectDispStatusBar = new Cognex.VisionPro.CogDisplayStatusBarV2();
            this.PostInspectDisplay = new Cognex.VisionPro.Display.CogDisplay();
            this.btnInspect = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreInspectDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostInspectDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 654);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.InfoBox);
            this.tabPage1.Controls.Add(this.btnInspect);
            this.tabPage1.Controls.Add(this.PostInspectDispStatusBar);
            this.tabPage1.Controls.Add(this.PostInspectDisplay);
            this.tabPage1.Controls.Add(this.PreInspectDispStatusBar);
            this.tabPage1.Controls.Add(this.PreInspectDisplay);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1024, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1024, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PreInspectDisplay
            // 
            this.PreInspectDisplay.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.PreInspectDisplay.ColorMapLowerRoiLimit = 0D;
            this.PreInspectDisplay.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.PreInspectDisplay.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.PreInspectDisplay.ColorMapUpperRoiLimit = 1D;
            this.PreInspectDisplay.DoubleTapZoomCycleLength = 2;
            this.PreInspectDisplay.DoubleTapZoomSensitivity = 2.5D;
            this.PreInspectDisplay.Location = new System.Drawing.Point(88, 174);
            this.PreInspectDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.PreInspectDisplay.MouseWheelSensitivity = 1D;
            this.PreInspectDisplay.Name = "PreInspectDisplay";
            this.PreInspectDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PreInspectDisplay.OcxState")));
            this.PreInspectDisplay.Size = new System.Drawing.Size(336, 192);
            this.PreInspectDisplay.TabIndex = 1;
            // 
            // PreInspectDispStatusBar
            // 
            this.PreInspectDispStatusBar.CoordinateSpaceName = "*\\#";
            this.PreInspectDispStatusBar.CoordinateSpaceName3D = "*\\#";
            this.PreInspectDispStatusBar.Location = new System.Drawing.Point(88, 372);
            this.PreInspectDispStatusBar.Name = "PreInspectDispStatusBar";
            this.PreInspectDispStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PreInspectDispStatusBar.Size = new System.Drawing.Size(336, 21);
            this.PreInspectDispStatusBar.TabIndex = 5;
            this.PreInspectDispStatusBar.Use3DCoordinateSpaceTree = false;
            // 
            // PostInspectDispStatusBar
            // 
            this.PostInspectDispStatusBar.CoordinateSpaceName = "*\\#";
            this.PostInspectDispStatusBar.CoordinateSpaceName3D = "*\\#";
            this.PostInspectDispStatusBar.Location = new System.Drawing.Point(531, 374);
            this.PostInspectDispStatusBar.Name = "PostInspectDispStatusBar";
            this.PostInspectDispStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PostInspectDispStatusBar.Size = new System.Drawing.Size(312, 21);
            this.PostInspectDispStatusBar.TabIndex = 7;
            this.PostInspectDispStatusBar.Use3DCoordinateSpaceTree = false;
            // 
            // PostInspectDisplay
            // 
            this.PostInspectDisplay.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.PostInspectDisplay.ColorMapLowerRoiLimit = 0D;
            this.PostInspectDisplay.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.PostInspectDisplay.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.PostInspectDisplay.ColorMapUpperRoiLimit = 1D;
            this.PostInspectDisplay.DoubleTapZoomCycleLength = 2;
            this.PostInspectDisplay.DoubleTapZoomSensitivity = 2.5D;
            this.PostInspectDisplay.Location = new System.Drawing.Point(523, 174);
            this.PostInspectDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.PostInspectDisplay.MouseWheelSensitivity = 1D;
            this.PostInspectDisplay.Name = "PostInspectDisplay";
            this.PostInspectDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PostInspectDisplay.OcxState")));
            this.PostInspectDisplay.Size = new System.Drawing.Size(320, 192);
            this.PostInspectDisplay.TabIndex = 6;
            // 
            // btnInspect
            // 
            this.btnInspect.Location = new System.Drawing.Point(88, 49);
            this.btnInspect.Name = "btnInspect";
            this.btnInspect.Size = new System.Drawing.Size(216, 72);
            this.btnInspect.TabIndex = 8;
            this.btnInspect.Text = "Load Next Image and Inspect";
            // 
            // InfoBox
            // 
            this.InfoBox.AcceptsReturn = true;
            this.InfoBox.Location = new System.Drawing.Point(131, 431);
            this.InfoBox.Multiline = true;
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoBox.Size = new System.Drawing.Size(696, 152);
            this.InfoBox.TabIndex = 9;
            // 
            // frmAllTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 654);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAllTool";
            this.Text = "frmAllTool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreInspectDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostInspectDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        internal Cognex.VisionPro.Display.CogDisplay PreInspectDisplay;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.TextBox InfoBox;
        internal System.Windows.Forms.Button btnInspect;
        internal Cognex.VisionPro.CogDisplayStatusBarV2 PostInspectDispStatusBar;
        internal Cognex.VisionPro.Display.CogDisplay PostInspectDisplay;
        internal Cognex.VisionPro.CogDisplayStatusBarV2 PreInspectDispStatusBar;
    }
}