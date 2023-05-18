using Cognex.VisionPro.CalibFix;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognex.VisionPro.PMAlign;
using Cognex.VisionPro.Display;
using System.Windows;

namespace AppVision.VisionPro
{
    public class CameraVPro : ObservableObject
    {
        public CogAcqFifoEditV2 CogAcqFifoEdit { get; set; }
        public CogImageFileEditV2 CogImageFileEdit { get; set; }
        public CogCalibCheckerboardEditV2 CogCalibGrid { get; set; }
        public CogPMAlignEditV2 CogPMAlign { get; set; }
        public CogDisplay CogDisplayOut { get; set; }
        public AutoCalibTool RTCAutoCalibTool { get; set; }



        public bool AutoCalibRunning { get; set; }




        private int currentCameraIndex;
        public int CurrentCameraIndex
        {
            get { return currentCameraIndex; }
            set
            {
                currentCameraIndex = value;
                OnPropertyChanged("CurrentCameraIndex");
            }
        }

        public delegate void DoubleClickDelegate(int index);
        public event DoubleClickDelegate DoubleClickDisplayEvent;


        public CameraVPro()
        {
            // Thiết lập Camera đầu vào
            CogAcqFifoEdit = new CogAcqFifoEditV2();
            CogAcqFifoEdit.Subject = new CogAcqFifoTool();
            CogImageFileEdit = new CogImageFileEditV2();
            CogImageFileEdit.Subject = new CogImageFileTool();

            // Khai báo tool Calib. Đầu vào ảnh từ Tool Acq.
            CogCalibGrid = new CogCalibCheckerboardEditV2();
            CogCalibGrid.Subject = new CogCalibCheckerboardTool();

            // Khai báo hiển thị đầu ra
            CogDisplayOut = new CogDisplay();
            CogDisplayOut.DoubleClick += ProcessDoubleClickDisplay;

            // Khai báo tool Align. Mặc định link đầu vào ảnh với Tool Acq
            CogPMAlign = new CogPMAlignEditV2();
            CogPMAlign.Subject = new CogPMAlignTool();

            // Khai báo Tool AutoCalib
            RTCAutoCalibTool = new AutoCalibTool();
            // Khởi tạo Autocalib
            AutoCalibRunning = false;

            // Khởi tạo CameraIndex
            currentCameraIndex = -1;
        }

        private void ProcessDoubleClickDisplay(object sender, EventArgs e)
        {
            if (DoubleClickDisplayEvent != null) DoubleClickDisplayEvent(currentCameraIndex);
        }

        public bool Load(int CameraIndex)
        {
            currentCameraIndex = CameraIndex;
            string[] writeStrings = new string[10];
            string urlTool = Helper.CreatDirectionCameraVpro(CameraIndex); // tạo đc 1 đường dẫn

            try
            {
                CogAcqFifoEdit.Subject = (CogAcqFifoTool)Cognex.VisionPro.CogSerializer.LoadObjectFromFile(urlTool + "\\CogAcqFifoEdit.vpp"); // Tệp vpp là tệp tin chương trình đã trained
                CogCalibGrid.Subject = (CogCalibCheckerboardTool)Cognex.VisionPro.CogSerializer.LoadObjectFromFile(urlTool + "\\CogCalibGrid.vpp");
                CogPMAlign.Subject = (CogPMAlignTool)Cognex.VisionPro.CogSerializer.LoadObjectFromFile(urlTool + "\\CogPMAlign.vpp");
                RTCAutoCalibTool.Load(CameraIndex);
                currentCameraIndex = CameraIndex;
                //
                CogDisplayOut.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF394261");
                CogDisplayOut.HorizontalScrollBar = false;
                CogDisplayOut.VerticalScrollBar = false;
                //CogCalibGrid.Subject.InputImage = CogImageFileEdit.Subject.OutputImage;
                CogCalibGrid.Subject.InputImage = CogAcqFifoEdit.Subject.OutputImage;
                CogPMAlign.Subject.InputImage = CogCalibGrid.Subject.OutputImage;
                Helper.WriteLogString($"Load Camera {CameraIndex}");
                Console.WriteLine($"Load Camera {CameraIndex}");
            }
            catch
            {
                Console.WriteLine($"Fail Load Camera {CameraIndex}");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Kiểm tra điều kiện bắt đầu chạy Autocalib
        /// 1. Đã khai báo Camera
        /// 2. Đã Calib Grid
        /// 3. Đã train xong Pattern
        /// </summary>
        /// <returns></returns>
        private string CheckConditionStartAutoCalib()
        {
            return "OK";
        }

        private string nameToolRB = "0";

        public string Command(string cmd)
        {
            Console.WriteLine(cmd);
            switch (Helper.GetCommandId(cmd))
            {
                case "HEB":
                    string result = CheckConditionStartAutoCalib();
                    if (result == "OK")
                    {
                        RTCAutoCalibTool.ResetReceiveData();
                        AutoCalibRunning = true;
                        return "HE,1";
                    }
                    else
                    {
                        MessageBox.Show("Không đủ điều kiện chạy!\r\n" + result);
                        return "HE,0";
                    }
                    break;
                case "HE":
                    PointWithTheta tempCamPoint = GetNormalAlign();
                    PointWithTheta tempRobotPoint = Helper.GetRobotPointFromCmd(cmd);
                    //tempCamPoint.Theta = 0;
                    if (tempCamPoint != null) RTCAutoCalibTool.AddPoint(tempCamPoint, tempRobotPoint);
                    else return "HE,0";
                    break;
                case "HEE":
                    if (RTCAutoCalibTool.NumberPoints < 11)
                    {
                        MessageBox.Show("Not Enough Calib Point! N = " + RTCAutoCalibTool.NumberPoints.ToString());
                        return "HE,0";
                    }
                    if (RTCAutoCalibTool.CalculateNPoint())
                    {
                        MessageBox.Show("AutoCalib Done!");
                        AutoCalibRunning = false;
                        return "HE,1";
                    }
                    else
                    {
                        MessageBox.Show("AutoCalib Fail!");
                        AutoCalibRunning = false;
                        return "HEE,0";
                    }
                    break;
                case "TM":
                    nameToolRB = Helper.GetNameTM(cmd);
                    return "TM,1";
                    break;
                case "TT":

                    var tempPointTT = GetNormalAlign();
                    if (tempPointTT != null)
                    {
                        if (nameToolRB == "1\r\n") RTCAutoCalibTool.CalTTTransMatrixPoint(cmd, tempPointTT);
                        //else if (nameToolRB == "2") RTCAutoCalibTool.CalTTTransMatrix1(cmd, tempPointTT);
                        return "TT,1";
                    }
                    else return "TT,0";

                case "XT":
                    string tempMessage;
                    string x = Helper.GetNameXT(cmd);
                    if (Helper.GetNameXT(cmd) == "a") { tempPoint = CalculateAlignRB(); }
                    else if (Helper.GetNameXT(cmd) == "b") { tempPoint = CalculateAlignRB1(); }
                    else if (Helper.GetNameXT(cmd) == "ab") { tempPoint = CalculateAlignRB(); tempPoint1 = CalculateAlignRB1(); }
                    else if (Helper.GetNameXT(cmd) == "c") { tempPointTest = CalculateAlignRBTest(); }
                    if (tempPoint != null && tempPoint1 == null)
                    {

                        tempMessage = Helper.CreatXTMessage(tempPoint);
                        tempPoint = null;
                    }
                    else if (tempPoint != null & tempPoint1 != null)
                    {
                        tempMessage = Helper.CreatXTMessageALL(tempPoint, tempPoint1);
                        tempPoint = null;
                        tempPoint1 = null;
                    }
                    else if (tempPointTest != null)
                    {
                        tempMessage = " ";
                        tempMessage = Helper.CreatXTMessageMultiPattern(tempPointTest);
                        tempMessage = "XT,1," + tempMessage;
                        tempPointTest = null;
                    }
                    else return "XT,0";
                    return tempMessage;
                default:
                    break;
            }
            return "HE,1";
        }

        public PointWithTheta GetNormalAlign()
        {
            CogAcqFifoEdit.Subject.Run();
            // Chụp ảnh, gửi ảnh sang Tool Calib
            if (CogAcqFifoEdit.Subject.RunStatus.Result != CogToolResultConstants.Accept)
            {
                MessageBox.Show(CogAcqFifoEdit.Subject.RunStatus.Exception.Message);
                return null;
            }
            else
            {
                CogCalibGrid.Subject.InputImage = CogAcqFifoEdit.Subject.OutputImage;
            }
            CogCalibGrid.Subject.Run();
            // Calib xong gửi ảnh qua Tool Align
            if (CogCalibGrid.Subject.RunStatus.Result != CogToolResultConstants.Accept)
            {
                MessageBox.Show(CogCalibGrid.Subject.RunStatus.Exception.Message);
                return null;
            }
            else
            {
                CogPMAlign.Subject.InputImage = CogCalibGrid.Subject.OutputImage;
            }
            CogPMAlign.Subject.Run();
            // Chạy xong Tool Align trả tọa độ + góc ra đầu ra
            if (CogPMAlign.Subject.RunStatus.Result != CogToolResultConstants.Accept)
            {
                MessageBox.Show(CogPMAlign.Subject.RunStatus.Exception.Message);
                return null;
            }
            else
            {
                if (CogPMAlign.Subject.Results.Count > 0)
                {
                    float tempX = (float)CogPMAlign.Subject.Results[0].GetPose().TranslationX;
                    float tempY = (float)CogPMAlign.Subject.Results[0].GetPose().TranslationY;
                    float tempTheta = -(float)CogPMAlign.Subject.Results[0].GetPose().Rotation;

                    // Trả hiển thị ra CogDisplay
                    App.Current.Dispatcher.BeginInvoke(new Action(delegate
                    {
                        CogDisplayOut.Image = CogAcqFifoEdit.Subject.OutputImage;
                        CogDisplayOut.StaticGraphics.Add(CogPMAlign.Subject.Results[0].CreateResultGraphics(CogPMAlignResultGraphicConstants.CoordinateAxes), "");
                    }));
                    Console.WriteLine($"{tempX}, {tempY}, {tempTheta}");
                    return new PointWithTheta(tempX, tempY, tempTheta);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
