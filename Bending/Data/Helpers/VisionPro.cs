using Bending.UC;
using Cognex.VisionPro;
using Cognex.VisionPro.Display;
using Cognex.VisionPro.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bending.Data.Helpers
{
    public class VisionPro
    {

        private ICogAcqFifo AcqFifo;
        private ICogFrameGrabber FrameGrabber;


        public  CogAcqFifoTool AcqFifoTool { get; set; }




        public void Capture(ICogFrameGrabber frameGrabber, CogDisplay Display)
        {
            string VIDEOFORMAT = "Generic GigEVision (Mono)";
            int acqTicket, completeTicket, triggerNumber, numPending, numReady;
            bool busy;

            AcqFifo = frameGrabber.CreateAcqFifo(VIDEOFORMAT, CogAcqFifoPixelFormatConstants.Format8Grey, 0, false);
            acqTicket = AcqFifo.StartAcquire();

                do
                {
                    AcqFifo.GetFifoState(out numPending, out numReady, out busy);

                    if ( numReady > 0)
                    {
                    Display.Image = AcqFifo.CompleteAcquire(acqTicket, out completeTicket, out triggerNumber);

                    }
                } while (numReady < 0);

        }

        public void LiveCamera(ICogFrameGrabber frameGrabber, CogDisplay Display)
        {
            string VIDEOFORMAT = "Generic GigEVision (Mono)";

            AcqFifo = frameGrabber.CreateAcqFifo(VIDEOFORMAT, CogAcqFifoPixelFormatConstants.Format8Grey, 0, false);
            Display.StartLiveDisplay(AcqFifo);

        }
        public void StopLiveCamera(CogDisplay Display)
        {
            if (Display.LiveDisplayRunning)
                Display.StopLiveDisplay();

        }
    }
}
