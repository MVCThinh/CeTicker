using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Models.Setting
{
    public class CamSetting
    {
        public string FOVX { get; set; }
        public string FOVY { get; set; }
        public string Resolution { get; set; }
        public string Serial { get; set; }
        public int PatternSearchMode { get; set; }
        public int PatternSearchTool { get; set; }
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
        public string AlignOffsetX { get; set; }
        public string AlignOffsetY { get; set; }
        public string AlignOffsetT { get; set; }
        public string CalOffsetX { get; set; }
        public string CalOffsetY { get; set; }
        public string CalOffsetT { get; set; }
        public string LengthOffset1 { get; set; }
        public string LengthOffset2 { get; set; }
        public string MarkPositionTolX { get; set; }
        public string MarkPositionTolY { get; set; }
        public string MaxSizeX { get; set; }
        public string MaxSizeY { get; set; }
        public int AlignRefSearch { get; set; }
        public int UseImageProcessing { get; set; }
        public int BlobSearchMaxPos { get; set; }
        public int BlobBoxUsePoint { get; set; }
        public int BlobPolarity { get; set; }
        public string ConnectivityMinPixels { get; set; }
        public int MCRSearch { get; set; }
        public int MCRRight { get; set; }
        public int MCRUp { get; set; }
        public int InspectDegreeKind { get; set; }
        public string LaserAlignRefPosTol { get; set; }
    }
}
