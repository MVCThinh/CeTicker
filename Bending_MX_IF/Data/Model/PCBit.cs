using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending_MX_IF.Data.Model
{
    public class PCBit
    {
        public int BITCONTROL { get; set; }
        public int CALIBRATION { get; set; }
        public int REPLY { get; set; }
        public int PC_CAL_MOVE { get; set; }
        public int FFU { get; set; }
        public int ECS { get; set; }
        public int GMS { get; set; }
        public int UPS { get; set; }
        public int GPS { get; set; }
    }
}
