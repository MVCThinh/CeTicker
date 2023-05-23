using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Models
{
    public class ToolSetting
    {
        public int PatternSearchMode { get; set; }
        public int PatternSearchTool { get; set; }
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
