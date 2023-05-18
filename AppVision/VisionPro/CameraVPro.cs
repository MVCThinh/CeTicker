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
    }
}
