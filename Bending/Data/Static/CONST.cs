using rs2DAlign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Enums
{
    public static class CONST
    {
        public const double rad = Math.PI / 180;
        public const double rad90 = Math.PI / 2;
        public static bool plcAutomode = false;
        public static bool pcAutomode = false;


        public static bool m_bSystemLog = false;
        public static bool m_bInterfaceLog = false;
        public static bool m_bMotorADJLog = false;
        public static bool m_bAlignXDeltaLog = false;
        public static bool m_bAlignPanelLog = false;
        public static bool m_bAlignNoPressLog = false;
        public static bool m_bAlignFPCLog = false;
        public static bool m_bMeasBendingLog = false;


        public static bool m_bAutoStart = false;
        public static bool m_bOverlayShow = false;

        public static double[] m_dMainTraceY = new double[100];
        public static double[] m_dMainTraceZ = new double[100];
        public static double[] m_dMainTraceT = new double[100];

        public static double[,] m_dTraceY = new double[3, 100];
        public static double[,] m_dTraceZ = new double[3, 100];
        public static double[,] m_dTraceT = new double[3, 100];

        //TraceInfo
        public static double[] TracePoint = new double[3];

        public static double[] RadiusOfRotation = new double[3];
        public static double[] endPointZ = new double[3];

        // Align/ Mark
        public static cs2DAlign.ptXYT[] TPanel1 = new cs2DAlign.ptXYT[8];
        public static cs2DAlign.ptXYT[] TPanel2 = new cs2DAlign.ptXYT[8];
        public static cs2DAlign.ptXYT[] AFPC1 = new cs2DAlign.ptXYT[8];
        public static cs2DAlign.ptXYT[] AFPC2 = new cs2DAlign.ptXYT[8];





        

        public static bool RunMode;

        //Height Sensor IP
        public static string HeightIP;

        public static bool m_bPLCConnect = false;

        public static double BDScaleX1;
        public static double BDScaleY1;
        public static double BDScaleX2;
        public static double BDScaleY2;
        public static double INSPScaleX1;
        public static double INSPScaleY1;
        public static double INSPScaleX2;
        public static double INSPScaleY2;
        public static double AutoScaleSpec;

        public static cs2DAlign.ptXXYY INSPBDLAST;
        public static cs2DAlign.ptXXYY INSPBDAFTER;
    }
}
