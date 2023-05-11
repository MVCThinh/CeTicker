using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Models
{
    public class CamSetting
    {
        public string FOVX { get; set; }
        public string FOVY { get; set; }
        public string Resolution { get; set; }
        public string Serial { get; set; }
        public string LightComport { get; set; }
        public string LightChanel { get; set; }
        public string GrapDelay { get; set; }
        public string LightDelay { get; set; }

        public enum PatternSearchMode
        {
            LastBest = 1,
            AllBest
        }
        public enum PatternSearchTool
        {
            PMAlign = 1,
            SearchMax,
        }
        public enum CalType
        {
            Cam1Type =1,
            Cam2Type,
        }
        public enum LightType
        {
            Light5V= 1,
            Light12V
        }
        public enum CameraReverse
        {

        }

    }

}
