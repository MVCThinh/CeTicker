using Bending.UC;
using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bending.Data.Helpers
{
    public class VisionPro
    {
        // Lấy tất cả Camera đang kết nôi.
        public static CogFrameGrabbers frameGrabbers;
        public static ICogFrameGrabber[] frameGrabber;

        private static CogAcqFifoTool AcqFifoTool;

        static bool Laser1;


        // Lấy được tất cả cam. Lưu vào frameGrabber
        public static void GetConnectedCameras()
        {
            frameGrabbers = new CogFrameGrabbers();

            int cameraCount = frameGrabbers.Count;
            frameGrabber = new ICogFrameGrabber[cameraCount];

            if (cameraCount > 0)
            {
                for (int i = 0; i < cameraCount; i++)
                {
                    frameGrabber[i] = frameGrabbers[i];
                    LoadCameras(frameGrabber[i]);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy camera nào đang kết nối. \n\r" +
                    "Kiểm tra lại IP Camera trong phần mềm Cognex GigE Vision Configurator");
            }
        }

        public static void LoadCameras(ICogFrameGrabber frameGrabber)
        {          
            string cVISION_VIDEOFORMAT = "Generic GigEVision (Mono)";
            AcqFifoTool.Operator = frameGrabber.CreateAcqFifo(cVISION_VIDEOFORMAT, CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);
        }

        private static void LiveCamera()
        {

        }
    }
}
