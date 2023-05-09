using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Static
{
    public static class CalibControl
    {
        public struct plcRequest
        {
            //PLC -> PC bit
            public const short LoadingPre1Align = 0x0;
            public const short LoadingPre2Align = 0x01;

            public const short Laser1Align = 0x03;
            public const short Laser2Align = 0x04;

            public const short Laser1Inspection = 0x06;
            public const short Laser2Inspection = 0x07;

            public const short Laser1CellLog = 0x10;
            public const short Laser2CellLog = 0x11;

            public const short MCRRead1 = 0x13;
            public const short MCRRead2 = 0x14;
        }

        public struct pcReply
        {
            public const short LoadingPre1Align = 0x0;
            public const short LoadingPre2Align = 0x01;

            public const short Laser1Align = 0x03;
            public const short Laser2Align = 0x04;

            public const short Laser1Inspection = 0x06;
            public const short Laser2Inspection = 0x07;

            public const short MarkingDataCompare1 = 0xA;
            public const short MarkingDataCompare2 = 0xB;

            public const short Laser1CellLog = 0x10;
            public const short Laser2CellLog = 0x11;

            public const short MCRRead1 = 0x13;
            public const short MCRRead2 = 0x14;
        }

        public struct pcRequest
        {
            //PC -> PLC
            public const short LoadingPre1CalMove = 0x0;
            public const short LoadingPre1CalStart = 0x10;
            public const short LoadingPre2CalMove = 0x01;
            public const short LoadingPre2CalStart = 0x11;

            public const short LaserAlign1CalMove = 0x02;
            public const short LaserAlign1CalStart = 0x12;
            public const short LaserAlign2CalMove = 0x03;
            public const short LaserAlign2CalStart = 0x13;
        }
        public struct plcReply
        {
            //PLC -> PC
            public const short LoadingPre1CalMove = 0x0;
            public const short LoadingPre2CalMove = 0x01;

            public const short LaserAlign1CalMove = 0x02;
            public const short LaserAlign2CalMove = 0x03;

            public const short CalStartOK = 0x10;
            public const short CalStartNG = 0x11;
        }



    }
}
