using Bending.Data.Enums;
using Bending.Data.Models.Setting;
using Cognex.VisionPro;
using Cognex.VisionPro.CalibFix;
using Cognex.VisionPro.Display;
using Cognex.VisionPro.Exceptions;
using Cognex.VisionPro.ID;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bending.Data.Helpers
{
    public class CamVision
    {
        public CogDisplay cogDisplay { get; set; }
        public CogAcqFifoTool cogAcqFifoTool { get; set; }
        public ICogAcqTrigger cogAcqTrigger { get; set; }
        public eImageReverse CamReverseMode { get; set; }
        public CogCalibCheckerboardTool CheckerboardTool { get; set; }
        public int imCnt { get; set; }
        public System.Windows.Forms.Timer tmrLive { get; set; }
        public bool bCalib { get; set; }
        public bool LiveOn { get; set; }





        public bool bCamSerialCheck { get; set; }


        public bool Initial(ICogFrameGrabber cogFrameGrabber, CogDisplay cDS)
        {
            string cVISION_VIDEOFORMAT = "Generic GigEVision (Mono)";

            cogDisplay = cDS;
            cogAcqFifoTool = new CogAcqFifoTool();
            tmrLive = new System.Windows.Forms.Timer();

            try
            {
                cogAcqFifoTool.Operator = cogFrameGrabber.CreateAcqFifo(cVISION_VIDEOFORMAT, CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);
                cogAcqTrigger = cogAcqFifoTool.Operator.OwnedTriggerParams;


                tmrLive.Enabled = false;
                tmrLive.Tick += TmrLive_Tick;
                tmrLive.Interval = 100;



            }
            catch (Exception)
            {

                throw;
            }

            return true;


        }



        /// <summary>
        /// Live Cam or not
        /// </summary>
        /// <param name="live"></param>
        public void Live(bool live)
        {
            try
            {
                cogDisplay.AutoFit = live;
                imCnt = 0;
                tmrLive.Enabled = live;
                LiveOn = live;

                bCalib = live;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void TmrLive_Tick(object sender, EventArgs e)
        {
            try
            {
                LiveOrTrigger(bCalib);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void LiveOrTrigger(bool bCalib)
        {
            int acqTicket, completeTicket, triggerNumber, numPending, numReady;
            bool busy;

            do
            {
                acqTicket = cogAcqFifoTool.Operator.StartAcquire();

                cogAcqFifoTool.Operator.GetFifoState(out numPending, out numReady, out busy);

                Thread.Sleep(1);
            } while (numReady <= 0);

            Bitmap bmpTest = cogAcqFifoTool.Operator.CompleteAcquire(acqTicket, out completeTicket, out triggerNumber ).ToBitmap();

            //Xử lý xoay ảnh
            switch(CamReverseMode)
            {
                case eImageReverse.None:
                    break;
                case eImageReverse.XReverse:
                    bmpTest.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;
                case eImageReverse.YReverse:
                    bmpTest.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    break;
                case eImageReverse.AllReverse:
                    bmpTest.RotateFlip(RotateFlipType.RotateNoneFlipXY);
                    break;
                case eImageReverse.Reverse90:
                    bmpTest.RotateFlip(RotateFlipType.Rotate90FlipX);
                    break;
                case eImageReverse.Reverse270:
                    bmpTest.RotateFlip(RotateFlipType.Rotate270FlipX);
                    break;
                case eImageReverse.Reverse90XY:
                    bmpTest.RotateFlip(RotateFlipType.Rotate90FlipXY);
                    break;
                case eImageReverse.Reverse270XY:
                    bmpTest.RotateFlip(RotateFlipType.Rotate270FlipXY);
                    break;
            }

            if (bmpTest != null)
            {
                if (CheckerboardTool.Calibration.Calibrated && bCalib)
                {
                    CheckerboardTool.InputImage = new CogImage8Grey(bmpTest);
                    CheckerboardTool.Run();
                    cogDisplay.Image = CheckerboardTool.OutputImage;
                }
                else
                {
                    cogDisplay.Image = new CogImage8Grey(bmpTest);
                }
            }

            imCnt++;
            if (imCnt > 100)
            {
                GC.Collect();
                imCnt = 0;
            }

        }

    }
}
