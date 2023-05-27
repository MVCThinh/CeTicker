using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.Implementation;
using Cognex.VisionPro.PMAlign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bending.Foam
{
    public partial class PMAlign : Form
    {
        private CogFrameGrabbers FrameGrabbers;
        private ICogFrameGrabber FrameGrabber;

        private CogAcqFifoTool AcqFifoTool;
        private CogImageFileTool ImageFileTool;
        private CogPMAlignTool PMAlignTool;

        private CogRectangleAffine recTrain;
        private CogRectangle recSearch;

        bool settingUp;

        string VIDEOFORMAT = "Generic GigEVision (Mono)";

        public enum SettingUpConstants
        {
            SettingUpPMAlign,
            SettingLiveCamera
        }

        public PMAlign()
        {
            InitializeComponent();
        }

        private void PMAlign_Load(object sender, EventArgs e)
        {
            settingUp = false;
            txtInfo.Text = "Đây là Tool PMAlign";

            FrameGrabbers = new CogFrameGrabbers();
           // FrameGrabber = FrameGrabbers[0];

            AcqFifoTool = new CogAcqFifoTool();
       //     AcqFifoTool.Operator = FrameGrabber.CreateAcqFifo(VIDEOFORMAT, CogAcqFifoPixelFormatConstants.Format8Grey, 0, false);
            AcqFifoTool.Ran += AcqFifoTool_Ran;

            if (AcqFifoTool.Operator == null)
                rbFrameGrabber.Enabled = false;

            ImageFileTool = new CogImageFileTool();
            ImageFileTool.Ran += ImageFileTool_Ran;

            openFD.Filter = ImageFileTool.Operator.FilterText;
            openFD.CheckFileExists = true;
            openFD.ReadOnlyChecked = true;

            PMAlignTool = new CogPMAlignTool();
            PMAlignTool.Ran += PMAlignTool_Ran; ;
            

            recTrain = new CogRectangleAffine();
            recTrain  = PMAlignTool.Pattern.TrainRegion as CogRectangleAffine;
            if (recTrain != null)
            {
                recTrain.SetCenterLengthsRotationSkew(320, 240, 100, 100, 0, 0);
                recTrain.GraphicDOFEnable = CogRectangleAffineDOFConstants.Position |
                                            CogRectangleAffineDOFConstants.Rotation |
                                            CogRectangleAffineDOFConstants.Size;
            }

            recSearch = new CogRectangle();
            PMAlignTool.SearchRegion = recSearch;
            recSearch.SetCenterWidthHeight(320, 240, 640, 480);
            recSearch.GraphicDOFEnable = CogRectangleDOFConstants.Position |
                                            CogRectangleDOFConstants.Size;
            recSearch.Interactive = true;

        }


        private void PMAlign_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        private void PMAlignTool_Ran(object sender, EventArgs e)
        {
            if ((CogToolBase.SfCreateLastRunRecord | CogToolBase.SfRunStatus) > 0)
            {
                cdDisplay.StaticGraphics.Clear();
                if (PMAlignTool.Results == null)
                {
                    txtbScore.Text = "N/A";
                }
                else if (PMAlignTool.Results.Count > 0)
                {
                    txtbScore.Text = PMAlignTool.Results[0].Score.ToString("g3");
                    txtbScore.Refresh();

                    CogCompositeShape resultGraphics = new CogCompositeShape();
                    resultGraphics = PMAlignTool.Results[0].CreateResultGraphics(CogPMAlignResultGraphicConstants.All);
                    cdDisplay.InteractiveGraphics.Add(resultGraphics, "Match", false);

                }
                else
                {
                    txtbScore.Text = "N/A";
                }
            }
        }

        private void PMAlignTool_Ran(object sender, CogChangedEventArgs e)
        {
            if ((CogToolBase.SfCreateLastRunRecord | CogToolBase.SfRunStatus) > 0)
            {
                cdDisplay.StaticGraphics.Clear();
                if (PMAlignTool.Results == null)
                {
                    txtbScore.Text = "N/A";
                }
                else if (PMAlignTool.Results.Count > 0)
                {
                    txtbScore.Text = PMAlignTool.Results[0].Score.ToString("g3");
                    txtbScore.Refresh();

                    CogCompositeShape resultGraphics = new CogCompositeShape();
                    resultGraphics = PMAlignTool.Results[0].CreateResultGraphics(CogPMAlignResultGraphicConstants.All);
                    cdDisplay.InteractiveGraphics.Add(resultGraphics, "Match", false);

                }
                else
                {
                    txtbScore.Text = "N/A";
                }
            }
        }

        int num_acq = 0;
        private void AcqFifoTool_Ran(object sender, EventArgs e)
        {
            cdDisplay.StaticGraphics.Clear();
            cdDisplay.InteractiveGraphics.Clear();
            cdDisplay.Image = AcqFifoTool.OutputImage;

            // Đẩy Image vào Tool PMAlign, ImageFileTool
            PMAlignTool.InputImage = AcqFifoTool.OutputImage as CogImage8Grey;
            ImageFileTool.InputImage = AcqFifoTool.OutputImage as CogImage8Grey;

            // Giảm bộ nhớ bằng GC
            num_acq++;
            if (num_acq > 4)
            {
                GC.Collect();
                num_acq = 0;
            }
        }

        private void ImageFileTool_Ran(object sender, EventArgs e)
        {
            cdDisplay.StaticGraphics.Clear();
            cdDisplay.InteractiveGraphics.Clear();
            cdDisplay.Image = ImageFileTool.OutputImage;

            // Đẩy Image vào Tool PMAlign
            PMAlignTool.InputImage = ImageFileTool.OutputImage as CogImage8Grey;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            cdDisplay.StaticGraphics.Clear();
            cdDisplay.InteractiveGraphics.Clear();

            if (rbFrameGrabber.Checked)
            {
                // Cài đặt Live Camera or Stop Live
                if (cdDisplay.LiveDisplayRunning)
                {
                    cdDisplay.StopLiveDisplay();
                    EnableAll(SettingUpConstants.SettingLiveCamera);
                    AcqFifoTool.Run();
                }
                else if (AcqFifoTool.Operator != null)
                {
                    cdDisplay.StartLiveDisplay(AcqFifoTool.Operator, false);
                    DisableAll(SettingUpConstants.SettingLiveCamera);
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
                AcqFifoTool.Run();
            else
                ImageFileTool.Run();
        }

        private void rbFrameGrabber_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFrameGrabber.Checked)
            {
                btnOpenFile.Text = "Live Video";
                btnNextImage.Text = "Capture";
            }
            else
            {
                btnOpenFile.Text = "Open File";
                btnNextImage.Text = "Next Image";
            }
        }
        private void btnSetup_Click(object sender, EventArgs e)
        {
            if (!settingUp)
            {
                if (PMAlignTool.InputImage == null)
                {
                    MessageBox.Show("Chưa có Image được cho vào tool PMAlign");
                    return;
                }

                PMAlignTool.Pattern.TrainImage = PMAlignTool.InputImage;
                settingUp= true;
                DisableAll(SettingUpConstants.SettingUpPMAlign);

                cdDisplay.InteractiveGraphics.Clear();
                cdDisplay.StaticGraphics.Clear();

                cdDisplay.InteractiveGraphics.Add(PMAlignTool.Pattern.TrainRegion as ICogGraphicInteractive, "Train Region", false);
                if (PMAlignTool.SearchRegion != null)
                {
                    cdDisplay.StaticGraphics.Add(PMAlignTool.SearchRegion as ICogGraphic, "Search Region");
                }
            }
            else
            {
                settingUp = false;

                cdDisplay.InteractiveGraphics.Clear();
                cdDisplay.StaticGraphics.Clear();

                try
                {
                    PMAlignTool.Pattern.Train();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Train Pattern xảy ra lỗi " + ex.Message, "Train Pattern Error");
                }

                EnableAll(SettingUpConstants.SettingUpPMAlign);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            PMAlignTool.Run();
            if (PMAlignTool.RunStatus.Exception != null)
            {
                MessageBox.Show(PMAlignTool.RunStatus.Exception.Message, "PMAlign Tool Error");
            }
        }

        private void DisableAll(SettingUpConstants settings)
        {
            gbImageAcq.Enabled = false;
            gbPMAlign.Enabled = false;

            if (settings == SettingUpConstants.SettingUpPMAlign)
            {
                gbPMAlign.Enabled = true;
                btnSetup.Text = "OK";
                btnRun.Enabled = false;
            }
            else if (settings == SettingUpConstants.SettingLiveCamera)
            {
                gbImageAcq.Enabled = true;
                btnOpenFile.Text = "Stop Live";
                btnNextImage.Enabled = false;
                rbFrameGrabber.Enabled = false;
                rbImageFile.Enabled = false;
            }
        }

        private void EnableAll(SettingUpConstants settings)
        {
            gbImageAcq.Enabled = true;
            gbPMAlign.Enabled = true;

            if (settings == SettingUpConstants.SettingUpPMAlign)
            {
                btnSetup.Text = "Setup";
                btnRun.Enabled = true;
            }
            else if (settings == SettingUpConstants.SettingLiveCamera)
            {
                btnOpenFile.Text = "Live Video";
                btnNextImage.Enabled = true;
                rbFrameGrabber.Enabled = true;
                rbImageFile.Enabled = true;
            }
        }








        //        CogFrameGrabbers frameGrabbers = new CogFrameGrabbers();
        //        ICogFrameGrabber frameGrabber = frameGrabbers.GrabberFromIndex(0); // Lấy Frame Grabber từ chỉ mục (index) 0

        //        ICogAcqFifo acqFifoOperator = frameGrabber.CreateAcqFifo(VIDEOFORMAT, CogAcqFifoPixelFormatConstants.Format8Grey, 0, false);
        //        AcqFifoTool = new CogAcqFifoTool(acqFifoOperator);
        //        AcqFifoTool.Ran += AcqFifoTool_Ran;

        ////    Kiểm tra giá trị của AcqFifoTool.Operator để điều chỉnh chức năng "optImageAcquisitionOptionFrameGrabber" tương ứng
        //      if (AcqFifoTool.Operator == null) {
        //    optImageAcquisitionOptionFrameGrabber.Enabled = false;
    }

}

