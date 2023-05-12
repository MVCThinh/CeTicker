using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Models.Setting
{
    internal class Laser1
    {
        public string FOVX { get; set; }
        public string FOVY { get; set; }
        public string Resolution { get; set; }
        public string Serial { get; set; }
        public int PatternSearchMode { get; set; }
        public int PatternSearchTool { get; set; }
        public int CalType { get; set; }
        public int LightType { get; set; }
        public string LighComport { get; set; }
        public string LightChanel { get; set; }
        public int CameraReverse { get; set; }
        public int ImageSaveType { get; set; }
        public string GrapDelay { get; set; }
        public string LightDelay { get; set; }
        public string AlignLimitX { get; set; }
        public string AlignLimitY { get; set; }
        public string AlignLimitT { get; set; }
        public string RetryLimitCount { get; set; }
        public string RetryCaptureCount { get; set; }
        public string ImageAutoDeleteDay { get; set; }
        public int CenterAlign { get; set; }
    }
}
