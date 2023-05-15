using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending_MX_IF.Data
{
    public class DeviceSetting
    {
        public int PLCType { get; set; }
        public string PLCIP { get; set; }
        public int StationNO { get; set; }
        public int NetworkNO { get; set; }
        public string PLCDevice { get; set; }
        public string SWVersion { get; set; }
        public string GPSIP { get; set; }
        public string UPSIP { get; set; }
    }
}
