using rs2DAlign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Static
{
    public static class DispChart
    {
        public static cs2DAlign.ptXXYY[] dist = new cs2DAlign.ptXXYY[8];
        public static bool[] bDrawPoint = new bool[8];
        public static int[] CountIn1 = new int[8];
        public static int[] CountIn2 = new int[8];
        public static int[] CountOut1 = new int[8];
        public static int[] CountOut2 = new int[8];
        public static int[] CountSquareOut1 = new int[8];
        public static int[] CountSquareOut2 = new int[8];
        public static int[] Count = new int[8];
        public static double[] SquareX = new double[8];
        public static double[] SquareY = new double[8];
    }
}
