using Cognex.VisionPro;
using Cognex.VisionPro.PMAlign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Models
{
    public class CamSetting
    {
        public bool Connected { get; set; }
        public string SerialNumber { get; set; }
        public ICogFrameGrabber framGrabber { get; set; }
        public CogPMAlignTool PMAlignTool { get; set; }
        public CogAcqFifoTool AcqFifoTool { get; set; }
    }
}
