using Bending.Data.Models.Setting;
using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.PMAlign;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Bending.Foam;
using Bending.Data.Models;
using Cognex.VisionPro.CalibFix;
using System.Drawing;
using System.Xml.Linq;
using System.Data.Odbc;

namespace Bending.UC
{
    public partial class ucRecipe : UserControl
    {
        // Lấy tất cả Camera đang kết nôi.
        private CogFrameGrabbers frameGrabbers;
        private ICogFrameGrabber[] frameGrabber;

        // Live, Open File
        private CogImageFileTool ImageFileTool;
        private CogAcqFifoTool[] AcqFifoTool;

        private CogPMAlignTool PMAlignToolRecipe;


        public static Dictionary<eCamName, CogAcqFifoTool> mapCamera;
        public static frmPattern patternRegister;


        public static CogPMAlignTool PMAlignTool1;
        public static CogPMAlignTool PMAlignTool2;

        string VIDEOFORMAT = "Generic GigEVision (Mono)";








        public static CamSetting[] Visions;
        public ucRecipe()
        {
            InitializeComponent();

            cbCamList.DataSource = Enum.GetValues(typeof(eCamName));
            GetConnectedCameras();


            //ImageFileTool = new CogImageFileTool();
            //ImageFileTool.Ran += ImageFileTool_Ran;

            //PMAlignToolRecipe = new CogPMAlignTool();
            //PMAlignTool1 = new CogPMAlignTool();
            //PMAlignTool2 = new CogPMAlignTool();


            //PMAlignTool1.Ran += PMAlignTool12_Ran;
            //PMAlignTool2.Ran += PMAlignTool12_Ran;

            //patternRegister = new frmPattern();




        }


        private void GetVisionConnected()
        {
            CogFrameGrabbers cogFrameGrabbers = new CogFrameGrabbers();
            int camConnected = cogFrameGrabbers.Count;

            if (camConnected > 0)
            {
                Visions = new CamSetting[camConnected];
                for (int i = 0; i < camConnected; i++)
                {
                    Visions[i] = new CamSetting();
                    Visions[i].framGrabber = cogFrameGrabbers[i];

                }
            }
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
            PMAlignToolRecipe.Ran += PMAlignToolRecipe_Ran;
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



        private CogCalibNPointToNPoint Calib9RBVS = new CogCalibNPointToNPoint();
        private ICogTransform2D TransPoint = null;

        private List<PointWT> listPointsRB = new List<PointWT>(11);
        private List<PointWT> listPointsVS = new List<PointWT>(11);

        PointWT pointPOvr = new PointWT();
        PointWT pointsPBase = new PointWT();

        private bool Calculate()
        {
            for (int i = 0; i < 9; i++)
            {
                Calib9RBVS.AddPointPair(listPointsRB[i].X, listPointsRB[i].Y, listPointsVS[i].X, listPointsVS[i].Y);
            }
            Calib9RBVS.Calibrate();
            if (!Calib9RBVS.Calibrated)
            {
                MessageBox.Show("Calib 9 Points Failed!");
                return false;
            }
            else
            {
                TransPoint = Calib9RBVS.GetComputedUncalibratedFromCalibratedTransform();
                //double[,] points2VSRaw = new double[2, 2]
                //{
                //    { listPointsVS[9].X, listPointsVS[9].Y },
                //    { listPointsVS[10].X, listPointsVS[10].Y }
                //};

                //double[,] points2VS = TransPoint.MapPoints(points2VSRaw);

                //PointWT point9VS = new PointWT(points2VS[0, 0], points2VS[0, 1], listPointsVS[9].R);
                //PointWT point10VS = new PointWT(points2VS[1, 0], points2VS[1, 1], listPointsVS[10].R);

                PointWT point9VS = TransfromPoint(TransPoint, listPointsVS[9]);
                PointWT point10VS = TransfromPoint(TransPoint, listPointsVS[10]);

                CalOriginPoint(point9VS, point10VS, listPointsRB[9], listPointsRB[10], ref pointPOvr, ref pointsPBase);
            }

            return true;

        }

        PointWT pointXTVS;
        PointWT pointXTRB;
       
        public bool RunXT(ICogTransform2D matrix, PointWT pointVSRaw)
        {
            pointXTVS = TransfromPoint(matrix, pointVSRaw);

            return true;
        }


        static PointWT PointPickUp(PointWT pointVSRaw, PointWT pointXTVS, PointWT pointXTRB,  ICogTransform2D matrix, PointWT POvr)
        {
            double XOvr = POvr.X;
            double YOvr = POvr.Y;
            double aOvr = POvr.R;


            double XPVs1 = pointXTVS.X;
            double YPVs1 = pointXTVS.Y;
            double aPVs1 = pointXTVS.R;

            double XPg1 = pointXTRB.X;
            double YPg1 = pointXTRB.Y;
            double aPg1 = pointXTRB.R;
          
            PointWT pointTT = TransfromPoint(matrix, pointVSRaw);
            double XPVs2 = pointTT.X;
            double YPVs2 = pointTT.Y;
            double aPVs2 = pointTT.R;


            // Calculate PGet2

            double XPg2 = -XOvr * Math.Cos(aOvr) - Math.Sin(aOvr) * YOvr + Math.Cos(aOvr) * XPVs2
                            + Math.Sin(aOvr) * YPVs2 + YPg1 * Math.Sin(aPVs1 - aPVs2) + XPg1 * Math.Cos(aPVs1 - aPVs2)
                            + XOvr * Math.Cos(aPVs1 + aOvr - aPVs2) - XPVs1 * Math.Cos(aPVs1 + aOvr - aPVs2)
                            + YOvr * Math.Sin(aPVs1 + aOvr - aPVs2) - YPVs1 * Math.Sin(aPVs1 + aOvr - aPVs2);

            double YPg2 = -Math.Cos(aOvr) * YOvr + XOvr * Math.Sin(aOvr) + Math.Cos(aOvr) * YPVs2 - Math.Sin(aOvr) * XPVs2
                            + YPg1 * Math.Cos(aPVs1 - aPVs2) - XPg1 * Math.Sin(aPVs1 - aPVs2) - XOvr * Math.Sin(aPVs1 + aOvr - aPVs2)
                            + XPVs1 * Math.Sin(aPVs1 + aOvr - aPVs2) + YOvr * Math.Cos(aPVs1 + aOvr - aPVs2) - YPVs1 * Math.Cos(aPVs1 + aOvr - aPVs2);

            double aPg2 = ((-aPVs2 + aPVs1 - aPg1) * 180) / Math.PI;


            return new PointWT(XPg2, YPg2, aPg2);
        }

        static PointWT TransfromPoint(ICogTransform2D TransMatrix, PointWT point)
        {
            double tempX, tempY;
            TransMatrix.MapPoint(point.X, point.Y, out tempX, out tempY);
            return new PointWT(tempX, tempY, point.R);
        }

        static void CalOriginPoint(PointWT point9VS, PointWT point10VS, PointWT point9RB, PointWT point10RB, ref PointWT pointPOvr, ref PointWT pointPBase)
        {
            double Xv10 = point9VS.X;
            double Yv10 = point9VS.Y;
            double av10 = point9VS.R;

            double Xv11 = point10VS.X;
            double Yv11 = point10VS.Y;
            double av11 = point10VS.R;

            double Xr10 = point9RB.X;
            double Yr10 = point9RB.Y;
            double ar10 = point9RB.R;

            double Xr11 = point10RB.X;
            double Yr11 = point10RB.Y;
            double ar11 = point10RB.R;


            // Calculate Points Origin VR
            double aOvr = 0;
            double XOvr = (-Xv10 - Yr10 * Math.Sin(aOvr) + Xr10 * Math.Cos(aOvr) - Yv11 * Math.Sin(-av11 + av10) + Yr10 * Math.Sin(av11 - av10 + aOvr)
                           + Xv10 * Math.Cos(-av11 + av10) + Xv11 * Math.Cos(-av11 + av10) + Yv10 * Math.Sin(-av11 + av10) - Xr10 * Math.Cos(av11 - av10 + aOvr)
                           + Yr11 * Math.Sin(-av11 + aOvr + av10) + Xr11 * Math.Cos(aOvr) - Yr11 * Math.Sin(aOvr) - Xr11 * Math.Cos(-av11 + aOvr + av10) - Xv11)
                            / (2 * Math.Cos(-av11 + av10) - 2);

            double YOvr = (-Yv10 + Yr10 * Math.Cos(aOvr) + Xr10 * Math.Sin(aOvr) + Yv10 * Math.Cos(-av11 + av10)
                            + Yv11 * Math.Cos(-av11 + av10) - Xv10 * Math.Sin(-av11 + av10)
                            + Xv11 * Math.Sin(-av11 + av10) - Yr10 * Math.Cos(av11 - av10 + aOvr) - Xr10 * Math.Sin(av11 - av10 + aOvr)
                            - Xr11 * Math.Sin(-av11 + aOvr + av10) + Yr11 * Math.Cos(aOvr) + Xr11 * Math.Sin(aOvr) - Yr11 * Math.Cos(-av11 + aOvr + av10) - Yv11)
                            / (2 * Math.Cos(-av11 + av10) - 2);

            // Calculate Points Origin PBase

            double xBase = (-Math.Cos(-av11 + aOvr) * Xr11 + Math.Sin(-av11 + aOvr) * Yr11 + Xv11 * Math.Cos(av11)
                            + Math.Sin(av11) * Yv11 + Math.Sin(-av10 + aOvr) * Yr10 - Math.Cos(-av10 + aOvr) * Xr10
                            + Xv10 * Math.Cos(av10) + Math.Sin(av10) * Yv10 - Math.Cos(av11) * Xv10
                            - Math.Sin(av10) * Yv11 - Xv11 * Math.Cos(av10) - Math.Sin(av11) * Yv10
                            - Yr10 * Math.Sin(-av11 + aOvr) + Xr10 * Math.Cos(-av11 + aOvr)
                            - Yr11 * Math.Sin(-av10 + aOvr) + Xr11 * Math.Cos(-av10 + aOvr)) / (2 * Math.Cos(-av11 + av10) - 2);


            double yBase = (-Math.Sin(-av11 + aOvr) * Xr11 - Math.Cos(-av11 + aOvr) * Yr11
                         + Math.Cos(av11) * Yv11 - Xv11 * Math.Sin(av11) - Math.Sin(-av10 + aOvr) * Xr10
                         - Math.Cos(-av10 + aOvr) * Yr10 + Yr10 * Math.Cos(-av11 + aOvr) + Xr10 * Math.Sin(-av11 + aOvr)
                         + Xr11 * Math.Sin(-av10 + aOvr) + Yr11 * Math.Cos(-av10 + aOvr) + Math.Cos(av10) * Yv10 - Xv10 * Math.Sin(av10)
                         + Math.Sin(av10) * Xv11 + Math.Sin(av11) * Xv10 - Yv11 * Math.Cos(av10) - Math.Cos(av11) * Yv10) / (2 * Math.Cos(-av11 + av10) - 2);

            double aBase = Math.Atan((-1 + Math.Cos(-av10 + ar10 + av11 - ar11)) / (Math.Sin(-av10 + ar10 + av11 - ar11)));


            pointPOvr = new PointWT(XOvr, YOvr, aOvr);
            pointPBase = new PointWT(xBase, yBase, aBase);



        }

    }


    public struct PointWT
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double R { get; set; }


        public PointWT(double X, double Y, double R)
        {
            this.X = X;
            this.Y = Y;
            this.R = R;
        }

    }
}
