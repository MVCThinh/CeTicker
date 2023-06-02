using Bending.Data.Models;
using Bending.UC;
using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.PMAlign;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Bending.Foam
{
    public partial class frmPattern : Form
    {
        private CogPMAlignTool PMAlignTool;
        private CogAcqFifoTool AcqFifoTool;
        private CogImageFileTool ImageFileTool;


        public static CogDictionary VisionToolDictionary;


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
            PMAlignTool = new CogPMAlignTool();

            VisionToolDictionary = new CogDictionary();


            ImageFileTool.Ran += ImageFileTool_Ran;
            AcqFifoTool.Ran += AcqFifoTool_Ran;
            PMAlignTool.Ran += PMAlignTool_Ran;


        }


        private void PMAlignTool_Ran(object sender, EventArgs e)
        {
            cdDisplay.InteractiveGraphics.Clear();
            cdDisplay.StaticGraphics.Clear();

            if (PMAlignTool.Results.Count > 0)
            {
                txtbScore.Text = Math.Round(PMAlignTool.Results[0].Score, 2).ToString();
                CogCompositeShape graphics = PMAlignTool.Results[0].CreateResultGraphics(CogPMAlignResultGraphicConstants.Origin |
                                                                                            CogPMAlignResultGraphicConstants.BoundingBox);
                cdDisplay.StaticGraphics.Add(graphics as ICogGraphic, "Match Features");

            }
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
            CogRectangleAffine recAff = new CogRectangleAffine();

            if (!settingUp)
            {
                if (PMAlignTool.InputImage == null)
                {
                    MessageBox.Show("Chưa có ảnh", "Thông báo");
                    return;
                }

                cdDisplay.InteractiveGraphics.Clear();
                cdDisplay.StaticGraphics.Clear();

                settingUp = true;
                btnSetup.Text = "OK";
                gbPMAlignResult.Enabled = false;
                gbImageAcq.Enabled = false;

                PMAlignTool.Pattern.TrainImage = PMAlignTool.InputImage;               
                recAff = PMAlignTool.Pattern.TrainRegion as CogRectangleAffine;
                if (recAff != null)
                {
                    recAff.SetCenterLengthsRotationSkew(PMAlignTool.InputImage.Width / 2, PMAlignTool.InputImage.Height / 2, 100, 100, 0, 0);
                    recAff.GraphicDOFEnable = CogRectangleAffineDOFConstants.Position |
                                                CogRectangleAffineDOFConstants.Rotation |
                                                CogRectangleAffineDOFConstants.Size;
                }
                cdDisplay.InteractiveGraphics.Add(PMAlignTool.Pattern.TrainRegion as ICogGraphicInteractive, "Train Region", false);
                recAff.TipText = "Train Region";


                PMAlignTool.Pattern.TrainAlgorithm = CogPMAlignTrainAlgorithmConstants.PatMaxAndPatQuick;
                PMAlignTool.Pattern.TrainMode = CogPMAlignTrainModeConstants.Image;
                PMAlignTool.Pattern.IgnorePolarity = cboxIgnorePolarity.Checked;
                PMAlignTool.Pattern.GrainLimitAutoSelect = true;
                PMAlignTool.Pattern.EdgeThreshold = double.Parse(txtbEdgeThreshold.Text);

                PMAlignTool.Pattern.TrainRegionMode = CogRegionModeConstants.PixelAlignedBoundingBoxAdjustMask;
                PMAlignTool.Pattern.Origin.TranslationX = recAff.CenterX;
                PMAlignTool.Pattern.Origin.TranslationY = recAff.CenterY;

                PMAlignTool.RunParams.RunAlgorithm = CogPMAlignRunAlgorithmConstants.BestTrained;
                PMAlignTool.RunParams.RunMode = CogPMAlignRunModeConstants.SearchImage;
                PMAlignTool.RunParams.ApproximateNumberToFind = (int)numudNumberToFind.Value;
                PMAlignTool.RunParams.AcceptThreshold = double.Parse(txtbAcceptThreshold.Text);

                PMAlignTool.RunParams.ScoreUsingClutter = cboxScoreUsingClutter.Checked;
                PMAlignTool.RunParams.ZoneAngle.Configuration = CogPMAlignZoneConstants.LowHigh;
                PMAlignTool.RunParams.ZoneAngle.Low = double.Parse(txtbAngleLow.Text) * Math.PI;
                PMAlignTool.RunParams.ZoneAngle.High = double.Parse(txtbAngleHigh.Text) * Math.PI;

                PMAlignTool.RunParams.ZoneScale.Configuration = CogPMAlignZoneConstants.LowHigh;
                PMAlignTool.RunParams.ZoneScale.Low = double.Parse(txtbScaleLow.Text);
                PMAlignTool.RunParams.ZoneScale.High = double.Parse(txtbScaleHigh.Text);

                CogRectangle rec = new CogRectangle();
                PMAlignTool.SearchRegion = rec;
                rec.SetCenterWidthHeight(PMAlignTool.InputImage.Width / 2, PMAlignTool.InputImage.Height / 2, 640, 480);
                rec.GraphicDOFEnable = CogRectangleDOFConstants.Position |
                                       CogRectangleDOFConstants.Size;

                cdDisplay.InteractiveGraphics.Add(PMAlignTool.SearchRegion as ICogGraphicInteractive, "Search Region", false);
                rec.Interactive = true;
                rec.TipText = "Search Region";
            }
            else
            {
                cdDisplay.InteractiveGraphics.Clear();
                cdDisplay.StaticGraphics.Clear();

                settingUp = false;
                btnSetup.Text = "Setup";
                gbPMAlignResult.Enabled = true;
                gbImageAcq.Enabled = true;
                gbControlTool.Enabled = true;
                try
                {
                    PMAlignTool.Pattern.Train();

                    if (PMAlignTool.Pattern.Trained)
                    {
                        modelToolName = tcPattern.SelectedTab.Text + " "+ numModelPMAlign.ToString();
                    }
                    else
                        modelToolName = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Train Pattern xảy ra lỗi " + ex.Message, "Train Pattern Error");
                }

            }
        }

        int numModelPMAlign = 1;
        string modelToolName = string.Empty;
        private void btnRun_Click(object sender, EventArgs e)
        {
            PMAlignTool.Run();
            if (PMAlignTool.RunStatus.Exception != null)
            {
                MessageBox.Show(PMAlignTool.RunStatus.Exception.Message, "PMAlign Tool Error");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {           
            if (!string.IsNullOrEmpty(modelToolName))
            {
                if(MessageBox.Show("Lưu Model " + modelToolName, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    VisionToolDictionary.Add(modelToolName, PMAlignTool);
                    lboxModel.Items.Add(modelToolName);

                    numModelPMAlign++;
                    modelToolName = string.Empty;
                }    
            }
            else
            {
                MessageBox.Show("Chưa có Model hoặc Model đã được thêm", "Thông báo");
            }

        }


    }
}
