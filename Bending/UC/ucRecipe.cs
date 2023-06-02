using Bending.Data.Enums;
using Bending.Data.Helpers;
using Bending.Data.Models.Setting;
using Cognex.VisionPro;
using Cognex.VisionPro.Display;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.PMAlign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Bending.Foam;
using static Bending.Foam.PMAlign;

namespace Bending.UC
{
    public partial class ucRecipe : UserControl
    {
        // Lấy tất cả Camera đang kết nôi.
        private CogFrameGrabbers frameGrabbers;
        private ICogFrameGrabber[] frameGrabber;

        // Live, Open File
        private  CogImageFileTool ImageFileTool;
        private CogAcqFifoTool[] AcqFifoTool;

        private CogPMAlignTool PMAlignToolRecipe;


        public static Dictionary<eCamName, CogAcqFifoTool> mapCamera;
        public static frmPattern patternRegister;


        public static CogPMAlignTool PMAlignTool1;
        public static CogPMAlignTool PMAlignTool2;

        string VIDEOFORMAT = "Generic GigEVision (Mono)";


        public ucRecipe()
        {
            InitializeComponent();

            cbCamList.DataSource = Enum.GetValues(typeof(eCamName));
            GetConnectedCameras();


            ImageFileTool = new CogImageFileTool();
            ImageFileTool.Ran += ImageFileTool_Ran;

            PMAlignToolRecipe = new CogPMAlignTool();
            PMAlignTool1 = new CogPMAlignTool();
            PMAlignTool2 = new CogPMAlignTool();

            PMAlignToolRecipe.Ran += PMAlignToolRecipe_Ran;
            PMAlignTool1.Ran += PMAlignTool12_Ran;
            PMAlignTool2.Ran += PMAlignTool12_Ran;

            patternRegister = new frmPattern();
        }


        // Lấy được tất cả cam. Lưu vào frameGrabber
        public void GetConnectedCameras()
        {
            mapCamera = new Dictionary<eCamName, CogAcqFifoTool>();
            frameGrabbers = new CogFrameGrabbers();
            int cameraCount = frameGrabbers.Count;

            if (cameraCount > 0)
            {
                frameGrabber = new ICogFrameGrabber[cameraCount];
                AcqFifoTool = new CogAcqFifoTool[cameraCount];

                for (int i = 0; i < cameraCount; i++)
                {
                    frameGrabber[i] = frameGrabbers[i];
                    AcqFifoTool[i] = new CogAcqFifoTool();
                    AcqFifoTool[i].Ran += AcqFifoTool_Ran;
                    string serialNumber = frameGrabber[i].SerialNumber;

                    if (serialNumber == VisionSetting.SerialLoading1)
                    {
                        VisionSetting.ConnectedLoadingPre1 = true;
                        AcqFifoTool[i].Operator = frameGrabber[i].CreateAcqFifo(VIDEOFORMAT, CogAcqFifoPixelFormatConstants.Format8Grey, 0, false);
                        mapCamera.Add(eCamName.LoadingPre1, AcqFifoTool[i]);
                        break;
                    }
                    else if (serialNumber == VisionSetting.SerialLoading2)
                    {
                        VisionSetting.ConnectedLoadingPre2 = true;
                        AcqFifoTool[i].Operator = frameGrabber[i].CreateAcqFifo(VIDEOFORMAT, CogAcqFifoPixelFormatConstants.Format8Grey, 0, false);
                        mapCamera.Add(eCamName.LoadingPre2, AcqFifoTool[i]);
                        break;
                    }
                    else if (serialNumber == VisionSetting.SerialLaser1)
                    {
                        VisionSetting.ConnectedLaser1 = true;
                        AcqFifoTool[i].Operator = frameGrabber[i].CreateAcqFifo(VIDEOFORMAT, CogAcqFifoPixelFormatConstants.Format8Grey, 0, false);
                        mapCamera.Add(eCamName.Laser1, AcqFifoTool[i]);
                        break;
                    }
                    else if (serialNumber == VisionSetting.SerialLaser2)
                    {
                        VisionSetting.ConnectedLaser2 = true;
                        AcqFifoTool[i].Operator = frameGrabber[i].CreateAcqFifo(VIDEOFORMAT, CogAcqFifoPixelFormatConstants.Format8Grey, 0, false);
                        mapCamera.Add(eCamName.Laser2, AcqFifoTool[i]);
                        break;
                    }

                }
            }
            else
            {
                // Kiểm tra frame grabber
                rbFrameGrabber.Enabled = (mapCamera.Count > 0) ? true : false;
                MessageBox.Show("Không tìm thấy camera nào đang kết nối. \n\r" +
                    "Kiểm tra lại IP Camera trong phần mềm Cognex GigE Vision Configurator");
            }
        }

        int num_acq = 0;
        private void AcqFifoTool_Ran(object sender, EventArgs e)
        {
            cdDisplay1.StaticGraphics.Clear();
            cdDisplay1.InteractiveGraphics.Clear();
            cdDisplay2.StaticGraphics.Clear();
            cdDisplay2.InteractiveGraphics.Clear();

            eCamName camName = (eCamName)cbCamList.SelectedItem;
            bool isLoadingPreCam = (camName == eCamName.LoadingPre1 || camName == eCamName.LoadingPre2);

            // Đẩy Image vào Tool PMAlign, ImageFileTool
            if (isLoadingPreCam)
            {
                cdDisplay1.Image = mapCamera[eCamName.LoadingPre1].OutputImage;
                cdDisplay2.Image = mapCamera[eCamName.LoadingPre2].OutputImage;

                PMAlignTool1.InputImage = mapCamera[eCamName.LoadingPre1].OutputImage as CogImage8Grey;
                PMAlignTool2.InputImage = mapCamera[eCamName.LoadingPre2].OutputImage as CogImage8Grey;
            }
            else
            {
                cdDisplay1.Image = mapCamera[eCamName.Laser1].OutputImage;
                cdDisplay2.Image = mapCamera[eCamName.Laser2].OutputImage;

                PMAlignTool1.InputImage = mapCamera[eCamName.Laser1].OutputImage as CogImage8Grey;
                PMAlignTool2.InputImage = mapCamera[eCamName.Laser2].OutputImage as CogImage8Grey;
            }
            
            // Giảm bộ nhớ bằng GC
            num_acq++;
            if (num_acq > 4)
            {
                GC.Collect();
                num_acq = 0;
            }
        }

        // Chỉ xử lý 1 màn hình
        private void ImageFileTool_Ran(object sender, EventArgs e)
        {
            cdDisplay2.StaticGraphics.Clear();
            cdDisplay2.InteractiveGraphics.Clear();

            cdDisplay2.Image = ImageFileTool.OutputImage;

            //Đẩy Image vào Tool PMAlign
            PMAlignTool1.InputImage = ImageFileTool.OutputImage as CogImage8Grey;
        }


        private void PMAlignToolRecipe_Ran(object sender, EventArgs e)
        {
            cdDisplay2.InteractiveGraphics.Clear();
            cdDisplay2.StaticGraphics.Clear();

            if (PMAlignToolRecipe.Results.Count > 0)
            {
                txtbScore.Text = Math.Round(PMAlignToolRecipe.Results[0].Score, 2).ToString();
                CogCompositeShape graphics = PMAlignToolRecipe.Results[0].CreateResultGraphics(CogPMAlignResultGraphicConstants.All);
                cdDisplay2.StaticGraphics.Add(graphics as ICogGraphic, "Match Features");

            }
        }

        private void PMAlignTool12_Ran(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void rbFrameGrabber_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFrameGrabber.Checked)
            {
                btnOpenFolder.Text = "Live Vision";
                btnNextImage.Text = "Capture";
            }
            else
            {
                btnOpenFolder.Text = "Open Folder";
                btnNextImage.Text = "Next Image";
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            cdDisplay1.InteractiveGraphics.Clear();
            cdDisplay1.StaticGraphics.Clear();
            cdDisplay2.InteractiveGraphics.Clear();
            cdDisplay2.StaticGraphics.Clear();

            if (rbFrameGrabber.Checked)
            {
                eCamName camName = (eCamName)cbCamList.SelectedItem;

                bool isLiveDisplayRunning = cdDisplay1.LiveDisplayRunning && cdDisplay2.LiveDisplayRunning;

                bool isLoadingPreCam = (camName == eCamName.LoadingPre1 || camName == eCamName.LoadingPre2);
                bool isLoadingPreOperatorAvailable = (mapCamera[eCamName.LoadingPre1].Operator != null && mapCamera[eCamName.LoadingPre2].Operator != null);
                bool isLaserOperatorAvailable = (mapCamera[eCamName.Laser1].Operator != null && mapCamera[eCamName.Laser2].Operator != null);

                // Cài đặt Live Camera or Stop Live
                if (isLiveDisplayRunning)
                {
                    cdDisplay1.StopLiveDisplay();
                    cdDisplay2.StopLiveDisplay();
                    EnableAll(SettingUpConstants.SettingLiveCamera);

                    if (isLoadingPreCam)
                    {
                        mapCamera[eCamName.LoadingPre1].Run();
                        mapCamera[eCamName.LoadingPre2].Run();
                    }
                    else
                    {
                        mapCamera[eCamName.Laser1].Run();
                        mapCamera[eCamName.Laser2].Run();
                    }

                }
                else if (isLoadingPreCam && isLoadingPreOperatorAvailable)
                {
                    cdDisplay1.StartLiveDisplay(mapCamera[eCamName.LoadingPre1].Operator, false);
                    cdDisplay2.StartLiveDisplay(mapCamera[eCamName.LoadingPre2].Operator, false);

                    DisableAll(SettingUpConstants.SettingLiveCamera);
                }
                else if (!isLoadingPreCam && isLaserOperatorAvailable)
                {
                    cdDisplay1.StartLiveDisplay(mapCamera[eCamName.Laser1].Operator, false);
                    cdDisplay2.StartLiveDisplay(mapCamera[eCamName.Laser2].Operator, false);

                    DisableAll(SettingUpConstants.SettingLiveCamera);
                }

            }
            else
            {
                // Cài đặt mở File từ Folder hiển thị hình ảnh ở cdDisplay2
                try
                {
                    if (openFD.ShowDialog() == DialogResult.OK && openFD.FileName != "")
                    {
                        ImageFileTool.Operator.Open(openFD.FileName, CogImageFileModeConstants.Read);
                        cdDisplay2.DrawingEnabled = false;
                        ImageFileTool.Run();
                        cdDisplay2.Fit(true);
                        cdDisplay2.DrawingEnabled = true;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi mở File " + ex.Message);
                }
            }

        }

        private void EnableAll(SettingUpConstants Settings)
        {

        }
        private void DisableAll(SettingUpConstants Settings)
        {

        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            if (rbFrameGrabber.Checked)
            {
                eCamName camName = (eCamName)cbCamList.SelectedItem;
                bool isLoadingPreCam = (camName == eCamName.LoadingPre1 || camName == eCamName.LoadingPre2);

                if (isLoadingPreCam)
                {
                    mapCamera[eCamName.LoadingPre1].Run();
                    mapCamera[eCamName.LoadingPre2].Run();
                }
                else
                {
                    mapCamera[eCamName.Laser1].Run();
                    mapCamera[eCamName.Laser2].Run();
                }
            }              
            else
                ImageFileTool.Run();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            patternRegister.ShowDialog();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            PMAlignToolRecipe.Run();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            lboxModel.Items.Clear();

            foreach (var item in patternRegister.lboxModel.Items)
            {
                lboxModel.Items.Add(item);
            }
        }

        private void btnLoadModel_Click(object sender, EventArgs e)
        {
            string model = lboxModel.SelectedItem.ToString();
            if (model != null)
            {
                PMAlignToolRecipe = new CogPMAlignTool((CogPMAlignTool)frmPattern.VisionToolDictionary[model]);
            }
           
        }
    }
}
