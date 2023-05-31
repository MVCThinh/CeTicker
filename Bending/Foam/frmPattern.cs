using Bending.UC;
using Cognex.VisionPro;
using Cognex.VisionPro.Display;
using Cognex.VisionPro.FGGigE;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.PMAlign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bending.Foam
{
    public partial class frmPattern : Form
    {
        private CogPMAlignTool PMAlignTool;
        private CogPMAlignPattern PMAlignPattern;
        private CogAcqFifoTool AcqFifoTool;
        private CogImageFileTool ImageFileTool;

        private CogRectangleAffine RectangleAffine;

        bool settingUp;



        public frmPattern()
        {
            InitializeComponent();

            cbCamList.DataSource = Enum.GetValues(typeof(eCamName));
            rbFrameGrabber.Enabled = (ucRecipe.mapCamera.Count > 0) ? true : false;
            cbCamList.Enabled = rbFrameGrabber.Enabled;

            settingUp = false;

            ImageFileTool = new CogImageFileTool();
            AcqFifoTool = new CogAcqFifoTool();
            PMAlignPattern = new CogPMAlignPattern();
            PMAlignTool = new CogPMAlignTool();

            RectangleAffine = new CogRectangleAffine();

            ImageFileTool.Ran += ImageFileTool_Ran;
            AcqFifoTool.Ran += AcqFifoTool_Ran;
            PMAlignPattern.Changed += PMAlignPattern_Changed;
            PMAlignTool.Ran += PMAlignTool_Ran;


        }

        private void PMAlignPattern_Changed(object sender, CogChangedEventArgs e)
        {
            if (PMAlignPattern.Trained)
            {
                lbTrain.Text = "Trained";
                lbTrain.BackColor = Color.Green;

                cdPatternTrain.Image = PMAlignPattern.GetTrainedPatternImage();
                cdPatternTrain.StaticGraphics.Add(PMAlignPattern.CreateGraphicsFine(CogColorConstants.Green) as ICogGraphic, "");
            }
            else
            {
                lbTrain.Text = "Not Trained";
                lbTrain.BackColor = Color.Red;
            }
            
        }

        private void PMAlignTool_Ran(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ImageFileTool_Ran(object sender, EventArgs e)
        {
            cdDisplay.StaticGraphics.Clear();
            cdDisplay.InteractiveGraphics.Clear();
            cdDisplay.Image = ImageFileTool.OutputImage;

            Bitmap image = ImageFileTool.OutputImage.ToBitmap();
            CogImage8Grey cogImage = new CogImage8Grey(image);

            // Đẩy Image vào Tool PMAlign
            PMAlignTool.InputImage = cogImage;
        }

        int num_acq = 0;
        private void AcqFifoTool_Ran(object sender, EventArgs e)
        {
            cdDisplay.StaticGraphics.Clear();
            cdDisplay.InteractiveGraphics.Clear();
            cdDisplay.Image = AcqFifoTool.OutputImage;

            // Đẩy Image vào Tool PMAlign, ImageFileTool
            PMAlignTool.InputImage = AcqFifoTool.OutputImage as CogImage8Grey;
          

            // Giảm bộ nhớ bằng GC
            num_acq++;
            if (num_acq > 4)
            {
                GC.Collect();
                num_acq = 0;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbFrameGrabber_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFrameGrabber.Checked)
            {
                btnOpenFile.Text = "Live Vision";
                btnNextImage.Text = "Capture";
            }
            else
            {
                btnOpenFile.Text = "Open Folder";
                btnNextImage.Text = "Next Image";
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            cdDisplay.InteractiveGraphics.Clear();
            cdDisplay.StaticGraphics.Clear();

            if (rbFrameGrabber.Checked)
            {
                eCamName camName = (eCamName)cbCamList.SelectedItem;
                AcqFifoTool = new CogAcqFifoTool(ucRecipe.mapCamera[camName]);
                // Cài đặt Live Camera or Stop Live
                if (cdDisplay.LiveDisplayRunning)
                {
                    cdDisplay.StopLiveDisplay();
                    //EnableAll(SettingUpConstants.SettingLiveCamera);
                    AcqFifoTool.Run();
                }
                else if (AcqFifoTool.Operator != null)
                {
                    cdDisplay.StartLiveDisplay(AcqFifoTool.Operator, false);
                    //DisableAll(SettingUpConstants.SettingLiveCamera);
                }
            }
            else
            {
                // Cài đặt mở File từ Folder
                try
                {
                    if (openFD.ShowDialog() == DialogResult.OK)
                    {
                        ImageFileTool.Operator.Open(openFD.FileName, CogImageFileModeConstants.Read);
                        cdDisplay.DrawingEnabled = false;
                        ImageFileTool.Run();
                        cdDisplay.Fit(true);
                        cdDisplay.DrawingEnabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi mở File " + ex.Message);
                }
            }
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            if (rbFrameGrabber.Checked)
            {
                eCamName camName = (eCamName)cbCamList.SelectedItem;
                AcqFifoTool = new CogAcqFifoTool(ucRecipe.mapCamera[camName]);
                AcqFifoTool.Run();
            }          
            else
                ImageFileTool.Run();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            if (!settingUp)
            {
                if (PMAlignTool.InputImage == null)
                {
                    MessageBox.Show("Chưa có Image được thêm vào Tool PMALign", "Thông báo");
                    return;
                }

                settingUp = true;
                PMAlignPattern.TrainImage = PMAlignTool.InputImage;

                cdDisplay.InteractiveGraphics.Clear();
                cdDisplay.StaticGraphics.Clear();

                RectangleAffine = PMAlignPattern.TrainRegion as CogRectangleAffine;
                if (RectangleAffine != null)
                {
                    RectangleAffine.SetCenterLengthsRotationSkew(320, 240, 100, 100, 0, 0);
                    RectangleAffine.GraphicDOFEnable = CogRectangleAffineDOFConstants.Position |
                                                CogRectangleAffineDOFConstants.Rotation |
                                                CogRectangleAffineDOFConstants.Size;
                }
                cdDisplay.InteractiveGraphics.Add(PMAlignPattern.TrainRegion as ICogGraphicInteractive, "Train Region", false);

                

            }
            else
            {
                settingUp = false;

                cdDisplay.InteractiveGraphics.Clear();
                cdDisplay.StaticGraphics.Clear();

                try
                {
                    PMAlignPattern.Train();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Train Pattern xảy ra lỗi " + ex.Message, "Train Pattern Error");
                }
            }
        }

        private void cboxShowGraphics_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxShowGraphics.Checked)
            {


            }
        }
    }
}
