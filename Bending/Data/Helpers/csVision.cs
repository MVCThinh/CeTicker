using Cognex.VisionPro;
using Cognex.VisionPro.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Helpers
{
    public class csVision
    {
        public CogDisplay cogDisplay { get; set; }
        public CogAcqFifoTool cogAcqFifoTool { get; set; }
        public ICogAcqTrigger cogAcqTrigger { get; set; }



        public bool bCamSerialCheck { get; set; }


        public bool Initial(ICogFrameGrabber cogFrameGrabber, CogDisplay cDS)
        {
            string cVISION_VIDEOFORMAT = "Generic GigEVision (Mono)";

            cogDisplay = cDS;
            cogAcqFifoTool = new CogAcqFifoTool();

            try
            {
                cogAcqFifoTool.Operator = cogFrameGrabber.CreateAcqFifo(cVISION_VIDEOFORMAT, CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);
                cogAcqTrigger = cogAcqFifoTool.Operator.OwnedTriggerParams;
            }
            catch (Exception)
            {

                throw;
            }




            return true;


        }
    }
}
