using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AppVision.VisionPro
{
    public static class TransformMatrixCal
    {
        public static Matrix4x4[] CalPBaseAndPOROC1(PointWithTheta robotPoint1, PointWithTheta robotPoint2, PointWithTheta camPoint1, PointWithTheta camPoint2)
        {
            float x_v10 = camPoint1.X;
            float y_v10 = camPoint1.Y;
            float angle_v10 = (float)camPoint1.Theta;

            float x_v11 = camPoint2.X;
            float y_v11 = camPoint2.Y;
            float angle_v11 = (float)camPoint2.Theta;

            float x_r10 = robotPoint1.X;
            float y_r10 = robotPoint1.Y;
            float angle_r10 = (float)robotPoint1.Theta;

            float x_r11 = robotPoint2.X;
            float y_r11 = robotPoint2.Y;
            float angle_r11 = (float)robotPoint2.Theta;

            float aOvr = angle_v10 - angle_r10 - (float)Math.Atan((-1 + Math.Cos((System.Double)(-angle_v10 + angle_r10 + angle_v11 - angle_r11))) / (Math.Sin((System.Double)(-angle_v10 + angle_r10 + angle_v11 - angle_r11))));
            aOvr = 0;
            float xOvr = (float)((1 / (2 * Math.Cos((System.Double)(angle_v10 - angle_v11)) - 2)) * (x_r10 * Math.Cos((System.Double)(aOvr)) - x_r10 * Math.Cos((System.Double)(-angle_v10 + aOvr + angle_v11)) + y_r10 * Math.Sin((System.Double)(-angle_v10 + aOvr + angle_v11)) - y_r10 * Math.Sin((System.Double)(aOvr)) + x_r11 * Math.Cos((System.Double)(aOvr)) - y_r11 * Math.Sin((System.Double)(aOvr)) - x_r11 * Math.Cos((System.Double)(angle_v10 - angle_v11 + aOvr)) + x_v10 * Math.Cos((System.Double)(angle_v10 - angle_v11)) + x_v11 * Math.Cos((System.Double)(angle_v10 - angle_v11)) + y_v10 * Math.Sin((System.Double)(angle_v10 - angle_v11)) - y_v11 * Math.Sin((System.Double)(angle_v10 - angle_v11)) + y_r11 * Math.Sin((System.Double)(angle_v10 - angle_v11 + aOvr)) - x_v11 - x_v10));
            float yOvr = (float)((1 / (2 * Math.Cos((System.Double)(angle_v10 - angle_v11)) - 2)) * (y_r11 * Math.Cos((System.Double)(aOvr)) + x_r11 * Math.Sin((System.Double)(aOvr)) - y_v11 - y_v10 + y_v11 * Math.Cos((System.Double)(angle_v10 - angle_v11)) - x_v10 * Math.Sin((System.Double)(angle_v10 - angle_v11)) + x_v11 * Math.Sin((System.Double)(angle_v10 - angle_v11)) - y_r11 * Math.Cos((System.Double)(angle_v10 - angle_v11 + aOvr)) - x_r11 * Math.Sin((System.Double)(angle_v10 - angle_v11 + aOvr)) + y_v10 * Math.Cos((System.Double)(angle_v10 - angle_v11)) + x_r10 * Math.Sin((System.Double)(aOvr)) - y_r10 * Math.Cos((System.Double)(-angle_v10 + aOvr + angle_v11)) - x_r10 * Math.Sin((System.Double)(-angle_v10 + aOvr + angle_v11)) + y_r10 * Math.Cos((System.Double)(aOvr))));

            Matrix4x4 POROC = new Matrix4x4((float)Math.Cos(aOvr), (float)-Math.Sin(aOvr), 0, (float)xOvr,
                                            (float)Math.Sin(aOvr), (float)Math.Cos(aOvr), 0, (float)yOvr,
                                            0, 0, 1, 0,
                                            0, 0, 0, 1);

            float aBase = (float)-Math.Atan2(-1 + Math.Cos((System.Double)(-angle_v10 + angle_r10 + angle_v11 - angle_r11)), Math.Sin((System.Double)(-angle_v10 + angle_r10 + angle_v11 - angle_r11)));
            float xBase = (float)((1 / (2 * Math.Cos((System.Double)(angle_v10 - angle_v11)) - 2)) * (-x_r11 * Math.Cos((System.Double)(aOvr - angle_v11)) + y_r11 * Math.Sin((System.Double)(aOvr - angle_v11)) + x_v11 * Math.Cos((System.Double)(angle_v11)) + y_v11 * Math.Sin((System.Double)(angle_v11)) + y_r10 * Math.Sin((System.Double)(aOvr - angle_v10)) - x_r10 * Math.Cos((System.Double)(aOvr - angle_v10)) + x_v10 * Math.Cos((System.Double)(angle_v10)) + y_v10 * Math.Sin((System.Double)(angle_v10)) - y_v11 * Math.Sin((System.Double)(angle_v10)) - x_v11 * Math.Cos((System.Double)(angle_v10)) - y_v10 * Math.Sin((System.Double)(angle_v11)) - x_v10 * Math.Cos((System.Double)(angle_v11)) - y_r11 * Math.Sin((System.Double)(aOvr - angle_v10)) + x_r11 * Math.Cos((System.Double)(aOvr - angle_v10)) - y_r10 * Math.Sin((System.Double)(aOvr - angle_v11)) + x_r10 * Math.Cos((System.Double)(aOvr - angle_v11))));

            float yBase = (float)((1 / (2 * Math.Cos((System.Double)(angle_v10 - angle_v11)) - 2)) * (-y_v11 * Math.Cos((System.Double)(angle_v10)) + x_v10 * Math.Sin((System.Double)(angle_v11)) - y_v10 * Math.Cos((System.Double)(angle_v11)) + y_r11 * Math.Cos((System.Double)(aOvr - angle_v10)) + x_r11 * Math.Sin((System.Double)(aOvr - angle_v10)) + y_r10 * Math.Cos((System.Double)(aOvr - angle_v11)) + x_r10 * Math.Sin((System.Double)(aOvr - angle_v11)) + x_v11 * Math.Sin((System.Double)(angle_v10)) - x_r11 * Math.Sin((System.Double)(aOvr - angle_v11)) - y_r11 * Math.Cos((System.Double)(aOvr - angle_v11)) + y_v11 * Math.Cos((System.Double)(angle_v11)) - x_v11 * Math.Sin((System.Double)(angle_v11)) - y_r10 * Math.Cos((System.Double)(aOvr - angle_v10)) + y_v10 * Math.Cos((System.Double)(angle_v10)) - x_v10 * Math.Sin((System.Double)(angle_v10)) - x_r10 * Math.Sin((System.Double)(aOvr - angle_v10))));

            Matrix4x4 PBase = new Matrix4x4((float)Math.Cos(aBase), (float)-Math.Sin(aBase), 0, (float)xBase,
                                (float)Math.Sin(aBase), (float)Math.Cos(aBase), 0, (float)yBase,
                                0, 0, 1, 0,
                                0, 0, 0, 1);
            return new Matrix4x4[2] { PBase, POROC };
        }
    }
}
