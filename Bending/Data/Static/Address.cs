using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Static
{
    public static class Address
    {  
        // Lưu vào struct để quản lý tốt hơn hay vì để nó ở toàn cục
        //[PLC -> PC Start Address]
        public struct PLC
        {
            //PLC -> PC
            public static int BITCONTROL;
            public static int REPLY;
            public static int MODE;
            public static int CURRENTPOSITION;
            public static int CHANGETIME;
            public static int CELLID1;
            public static int CELLID2;
            public static int CELLID3;
            public static int CELLID4;
            public static int CELLID5;
            public static int CELLID6;
            public static int CELLID7;
            public static int CELLID8;
            public static int INSPECTIONBENDINGLAST;
            public static int RECIPEID;
            public static int RECIPEPARAM;
            public static int POSITION;
            public static int PLC_CAL_MOVE;
            public static int BDSCALE;
            public static int INSPSCALE;
            public static int LaserSendCellID; //210118 cjm 레이저 로그
            public static int MCRCellID;    //210118 cjm 레이저 로그
        }

        public struct PC
        {
            //PC -> PLC
            public static int BITCONTROL;
            //public static int CIMIF;
            public static int CALIBRATION;
            public static int REPLY;
            public static int VISIONOFFSET;
            //public static int TraceInfoArm1;
            //public static int TraceInfoArm2;
            //public static int TraceInfoArm3;
            public static int BENDING1;
            public static int BENDING2;
            public static int BENDING3;
            public static int SV;
            public static int DV;
            public static int PC_CAL_MOVE;
            public static int TransferFirstOffset;
            public static int CPK;

            //pcy200506추가
            public static int FFU;
            public static int MatchingScore;
            public static int ESC;
            public static int GMS;
            public static int HeightInspection;

            public static int APNCode1;
            public static int APNCode2;
        }

        public struct VisionOffset
        {
            public static int LoadingPre1 = 0;
            public static int LoadingPre2 = 6;

            public static int LaserAlign1 = 12;
            public static int LaserAlign2 = 18;
        }



    }
}
