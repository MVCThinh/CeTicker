using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Models.Setting
{
    public class CamSetting
    {
        public string Name { get; set; }
        public bool Connected { get; set; }
        public string Serial { get; set; }
        public int LightType { get; set; }
        public string LighComport { get; set; }
        public string LightChanel { get; set; }
        public int ImageSaveType { get; set; }
        public string GrapDelay { get; set; }
        public string LightDelay { get; set; }
        public string RetryLimitCount { get; set; }
        public string RetryCaptureCount { get; set; }
        public string ImageAutoDeleteDay { get; set; }

    }
}
