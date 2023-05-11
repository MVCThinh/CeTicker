using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Models
{
    public class LaserModel
    {
        public string MarkPositionTolX { get; set; }
        public string MarkPositionTolY { get; set; }
        public string MaxSizeX { get; set; }
        public string MaxSizeY { get; set; }
        public string AlignRefSearch { get; set; }
        public string UseImageProcessing { get; set; }
        public string BlobSearchMaxPos { get; set; }
        public string BlobBoxUsePoint { get; set; }
        public string BlobPolarity { get; set; }
        public string ConnectivityMinPixels { get; set; }
        public string MCRSearch { get; set; }
        public string MCRRight { get; set; }
        public string MCRUp { get; set; }
        public string InspectDegreeKind { get; set; }
        public string LaserAlignRefPosTol { get; set; }
    }
}
