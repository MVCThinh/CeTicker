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
            this.cogDS = new Cognex.VisionPro.Display.CogDisplay();
            this.cogDS2 = new Cognex.VisionPro.Display.CogDisplay();
            ((System.ComponentModel.ISupportInitialize)(this.cogDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDS2)).BeginInit();
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
            // cogDS
            // 
            this.cogDS.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDS.ColorMapLowerRoiLimit = 0D;
            this.cogDS.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDS.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDS.ColorMapUpperRoiLimit = 1D;
            this.cogDS.DoubleTapZoomCycleLength = 2;
            this.cogDS.DoubleTapZoomSensitivity = 2.5D;
            this.cogDS.Location = new System.Drawing.Point(3, 200);
            this.cogDS.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDS.MouseWheelSensitivity = 1D;
            this.cogDS.Name = "cogDS";
            this.cogDS.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDS.OcxState")));
            this.cogDS.Size = new System.Drawing.Size(620, 425);
            this.cogDS.TabIndex = 85;
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
            this.cogDS2.Location = new System.Drawing.Point(622, 200);
            this.cogDS2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDS2.MouseWheelSensitivity = 1D;
            this.cogDS2.Name = "cogDS2";
            this.cogDS2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDS2.OcxState")));
            this.cogDS2.Size = new System.Drawing.Size(620, 425);
            this.cogDS2.TabIndex = 86;
            this.cogDS2.Visible = false;
            // 
            // ucRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cogDS2);
            this.Controls.Add(this.cogDS);
            this.Controls.Add(this.label63);
            this.Name = "ucRecipe";
            this.Size = new System.Drawing.Size(1886, 827);
            ((System.ComponentModel.ISupportInitialize)(this.cogDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDS2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label63;
        private Cognex.VisionPro.Display.CogDisplay cogDS;
        private Cognex.VisionPro.Display.CogDisplay cogDS2;
    }
}
