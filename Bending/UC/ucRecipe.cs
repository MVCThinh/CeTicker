using Bending.Data.Enums;
using Bending.Data.Helpers;
using Bending.Data.Models.Setting;
using Cognex.VisionPro;
using Cognex.VisionPro.Display;
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

namespace Bending.UC
{
    public partial class ucRecipe : UserControl
    {
        // Lấy tất cả Camera đang kết nôi.
        public static CogFrameGrabbers frameGrabbers;
        public static ICogFrameGrabber[] frameGrabber;

        public  VisionPro LoadingPre1 = new VisionPro();
        public  VisionPro LoadingPre2 = new VisionPro();
        public  VisionPro Laser1 = new VisionPro();
        public  VisionPro Laser2 = new VisionPro();


        public Dictionary<string, ICogFrameGrabber> mapCamera = new Dictionary<string, ICogFrameGrabber>();








        public ucRecipe()
        {
            InitializeComponent();


            cbCamList.DataSource = Enum.GetValues(typeof(eCamName));



        }


        // Lấy được tất cả cam. Lưu vào frameGrabber
        public void GetConnectedCameras()
        {
            frameGrabbers = new CogFrameGrabbers();

            int cameraCount = frameGrabbers.Count;
            frameGrabber = new ICogFrameGrabber[cameraCount];

            if (cameraCount > 0)
            {
                for (int i = 0; i < cameraCount; i++)
                {
                    frameGrabber[i] = frameGrabbers[i];
                    foreach (var camSetting in ucSetting.AllCamSetting)
                    {
                        if (camSetting.Serial == frameGrabber[i].SerialNumber)
                        {
                            camSetting.Connected = true;
                            mapCamera.Add(camSetting.Name, frameGrabber[i]);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy camera nào đang kết nối. \n\r" +
                    "Kiểm tra lại IP Camera trong phần mềm Cognex GigE Vision Configurator");
            }
        }


        private void cbCamList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void RefreshAll()
        {
            btnLiveCamera.Text = "Live Camera";
            btnLiveCamera.ForeColor = Color.Transparent;

        }
        private VisionPro GetCamSettingByCamName(eCamName camName)
        {
            switch (camName)
            {
                case eCamName.LoadingPre1:
                    return LoadingPre1;
                case eCamName.LoadingPre2:
                    return LoadingPre2;
                case eCamName.Laser1:
                    return Laser1;
                case eCamName.Laser2:
                    return Laser2;
                default:
                    return null;
            }
        }
        private void btnLiveImage_Click(object sender, EventArgs e)
        {
            eCamName camName = (eCamName)cbCamList.SelectedItem;
            cogDS1.InteractiveGraphics.Clear();
            cogDS2.InteractiveGraphics.Clear();

            if (camName == eCamName.LoadingPre1 || camName == eCamName.LoadingPre2)
            {
                LiveCamera(mapCamera[ucSetting.LoadingPre1.Name], cogDS1);
                LiveCamera(mapCamera[ucSetting.LoadingPre2.Name] , cogDS2);
            }
            else
            {
                LiveCamera(mapCamera[ucSetting.Laser1.Name], cogDS1);
                LiveCamera(mapCamera[ucSetting.Laser2.Name], cogDS2);
            }

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            eCamName camName = (eCamName)cbCamList.SelectedItem;
            cogDS1.InteractiveGraphics.Clear();
            cogDS2.InteractiveGraphics.Clear();

            if (camName == eCamName.LoadingPre1 || camName == eCamName.LoadingPre2)
            {
                Capture(mapCamera[ucSetting.LoadingPre1.Name], cogDS1);
                Capture(mapCamera[ucSetting.LoadingPre2.Name], cogDS2);
            }
            else
            {
                Capture(mapCamera[ucSetting.Laser1.Name], cogDS1);
                Capture(mapCamera[ucSetting.Laser2.Name], cogDS2);
            }
        }


        string VIDEOFORMAT = "Generic GigEVision (Mono)";
        private ICogAcqFifo AcqFifo;
        private void LiveCamera(ICogFrameGrabber frameGrabber, CogDisplay Display)
        {
            if (cogDS1.LiveDisplayRunning || cogDS2.LiveDisplayRunning)
            {
                btnLiveCamera.Text = "Stop Live";
                btnLiveCamera.ForeColor = Color.AliceBlue;
                Display.StopLiveDisplay();
                cbCamList.Enabled = true;
            }
            else
            {
                btnLiveCamera.Text = "Live Camera";
                btnLiveCamera.ForeColor = Color.Transparent;
                AcqFifo = frameGrabber.CreateAcqFifo(VIDEOFORMAT, CogAcqFifoPixelFormatConstants.Format8Grey, 0, false);
                Display.StartLiveDisplay(AcqFifo);
                cbCamList.Enabled = false;
            }    

        }

        private void Capture(ICogFrameGrabber frameGrabber, CogDisplay Display)
        {
            int acqTicket, completeTicket, triggerNumber, numPending, numReady;
            bool busy;

            AcqFifo = frameGrabber.CreateAcqFifo(VIDEOFORMAT, CogAcqFifoPixelFormatConstants.Format8Grey, 0, false);
            acqTicket = AcqFifo.StartAcquire();

            do
            {
                AcqFifo.GetFifoState(out numPending, out numReady, out busy);

                if (numReady > 0)
                {
                    Display.Image = AcqFifo.CompleteAcquire(acqTicket, out completeTicket, out triggerNumber);

                }
            } while (numReady < 0);

        }










        private void btnCal_Click(object sender, EventArgs e)
        {
            if (tmrCal.Enabled)
            {
                MessageBox.Show("Calibraition is not Finished");
                return;
            }
        }

        List<Point> lstRobotPoint = new List<Point>();
        List<Point> lstVisionPoint = new List<Point>();



        private void tmrCal_Tick(object sender, EventArgs e)
        {


        }


    }
}
