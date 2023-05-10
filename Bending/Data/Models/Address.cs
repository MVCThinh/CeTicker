using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Static
{

    //[PLC -> PC Start Address]
    public class PLC
    {
        public int BITCONTROL { get; set; }
        public int REPLY { get; set; }
        public int MODE { get; set; }
        public int CURRENTPOSITION { get; set; }
        public int CHANGETIME { get; set; }
        public int CELLID1 { get; set; }
        public int CELLID2 { get; set; }
        public int CELLID3 { get; set; }
        public int CELLID4 { get; set; }
        public int CELLID5 { get; set; }
        public int CELLID6 { get; set; }
        public int CELLID7 { get; set; }
        public int CELLID8 { get; set; }
        public int INSPECTIONBENDINGLAST { get; set; }
        public int RECIPEID { get; set; }
        public int RECIPEPARAM { get; set; }
        public int POSITION { get; set; }
        public int PLC_CAL_MOVE { get; set; }
        public int BDSCALE { get; set; }
        public int INSPSCALE { get; set; }
        public int LaserSendCellID { get; set; }
        public int MCRCellID { get; set; }

    }

    // PC -> PLC
    public class PC
    {
        public int BITCONTROL { get; set; }
        public int CALIBRATION { get; set; }
        public int REPLY { get; set; }
        public int VISIONOFFSET { get; set; }
        public int BENDING1 { get; set; }
        public int BENDING2 { get; set; }
        public int BENDING3 { get; set; }
        public int SV { get; set; }
        public int DV { get; set; }
        public int PC_CAL_MOVE { get; set; }
        public int TransferFirstOffset { get; set; }
        public int CPK { get; set; }
        public int FFU { get; set; }
        public int MatchingScore { get; set; }
        public int ESC { get; set; }
        public int GMS { get; set; }
        public int HeightInspection { get; set; }
        public int APNCode1 { get; set; }
        public int APNCode2 { get; set; }

    }

}


  