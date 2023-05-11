using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Models
{
    public class CamSettingModel
    {
        public string FOVX { get; set; }
        public string FOVY { get; set; }
        public string Resolution { get; set; }
        public string Serial { get; set; }
        public string PatternSearchMode { get; set; }
        public string PatternSearchTool { get; set; }
        public string CalType { get; set; }
        public string LightType { get; set; }
        public string LighComport { get; set; }
        public string LightChanel { get; set; }
        public string CameraReverse { get; set; }
        public string ImageSaveType { get; set; }
        public string GrapDelay { get; set; }
        public string LightDelay { get; set; }
        public string AlignLimitX { get; set; }
        public string AlignLimitY { get; set; }
        public string AlignLimitT { get; set; }
        public string RetryLimitCount { get; set; }
        public string RetryCaptureCount { get; set; }
        public string ImageAutoDeleteDay { get; set; }
        public string CenterAlign { get; set; }
    }

}
