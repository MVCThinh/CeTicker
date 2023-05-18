using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace AppVision.VisionPro
{
    public static class Helper
    {
        public static string GetNameTM(string cmd)
        {
            string[] tempArr = cmd.Split(',');
            string tempX;
            try
            {
                tempX = tempArr[2];
            }
            catch
            {
                return null;
            }
            return tempX;
        }

        public static string GetCommandId(string cmd)
        {
            if (cmd.IndexOf("HEB,") >= 0) return "HEB";
            if (cmd.IndexOf("HE,") >= 0) return "HE";
            if (cmd.IndexOf("HEE,") >= 0) return "HEE";
            if (cmd.IndexOf("TT,") >= 0) return "TT";
            if (cmd.IndexOf("XT,") >= 0) return "XT";
            if (cmd.IndexOf("TM,") >= 0) return "TM";
            return "";
        }

        public static PointWithTheta GetRobotPointFromCmd(string cmd)
        {
            string[] tempArr = cmd.Split(',');
            float tempX, tempY, tempTheta;
            try
            {
                tempX = float.Parse(tempArr[2]);
                tempY = float.Parse(tempArr[3]);
                tempTheta = float.Parse(tempArr[4]);
                //tempTheta = tempTheta - (float)(-138.7 * Math.PI / 180);
            }
            catch
            {
                return null;
            }
            return new PointWithTheta(tempX, tempY, tempTheta);

        }

        public static PointWithTheta TransPointFromNPoint(ICogTransform2D pointTransformToolFromNPointCalib, PointWithTheta inputPoint)
        {
            double tempX, tempY;
            pointTransformToolFromNPointCalib.MapPoint(inputPoint.X, inputPoint.Y, out tempX, out tempY);
            PointWithTheta outputPoint = new PointWithTheta((float)tempX, (float)tempY, inputPoint.Theta);
            return outputPoint;
        }

        public static string CreatDirectionCameraVpro(int cameraIndex)
        {
            string tempReturn = "";
            //tempReturn = "D:";
            tempReturn = Environment.CurrentDirectory;
            tempReturn += $"\\VProTool\\RTCCamera_0{cameraIndex}";
            return tempReturn;
        }

        public static string CreatDirectionAutoCalib(int cameraIndex)
        {
            string tempReturn = "";
            //tempReturn = "D:";
            tempReturn = Environment.CurrentDirectory;
            tempReturn += $"\\VProTool\\RTCCamera_0{cameraIndex}\\RTCAutoCalibTool";
            return tempReturn;
        }


        public static Matrix4x4[] LoadAutoCalibMatrix1(string urlTool)
        {
            Matrix4x4 transMatrixPBASE;
            Matrix4x4 transformTT;
            Matrix4x4 transMatrixPOROV;
            try
            {

                string url_transMatrixPBASE = urlTool + "\\transMatrixPBASE.rtc";
                string url_transformTT = urlTool + "\\transformTT1.rtc";
                string url_transMatrixPOROV = urlTool + "\\transMatrixPOROV.rtc";
                float[] arr_transMatrixPBASE = (float[])LoadObjFromFile(url_transMatrixPBASE);
                float[] arr_transformTT = (float[])LoadObjFromFile(url_transformTT);
                float[] arr_transMatrixPOROV = (float[])LoadObjFromFile(url_transMatrixPOROV);
                transMatrixPBASE = TransArrayToMatrix(arr_transMatrixPBASE);
                transformTT = TransArrayToMatrix(arr_transformTT);
                transMatrixPOROV = TransArrayToMatrix(arr_transMatrixPOROV);
            }
            catch { return null; }
            return new Matrix4x4[] { transMatrixPBASE, transformTT, transMatrixPOROV };
        }



        public static Matrix4x4[] LoadAutoCalibMatrix(string urlTool)
        {
            Matrix4x4 transMatrixPBASE;
            Matrix4x4 transformTT;
            Matrix4x4 transMatrixPOROV;

            try
            {

                string url_transMatrixPBASE = urlTool + "\\transMatrixPBASE.rtc";
                string url_transformTT = urlTool + "\\transformTT.rtc";
                string url_transMatrixPOROV = urlTool + "\\transMatrixPOROV.rtc";
                float[] arr_transMatrixPBASE = (float[])LoadObjFromFile(url_transMatrixPBASE);
                float[] arr_transformTT = (float[])LoadObjFromFile(url_transformTT);
                float[] arr_transMatrixPOROV = (float[])LoadObjFromFile(url_transMatrixPOROV);
                transMatrixPBASE = TransArrayToMatrix(arr_transMatrixPBASE);
                transformTT = TransArrayToMatrix(arr_transformTT);
                transMatrixPOROV = TransArrayToMatrix(arr_transMatrixPOROV);
            }
            catch { return null; }
            return new Matrix4x4[] { transMatrixPBASE, transformTT, transMatrixPOROV };
        }


        private static object LoadObjFromFile(string url)
        {
            object tempReturn = null;
            if (File.Exists(url))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream userFile = File.Open(url, FileMode.Open);
                tempReturn = binaryFormatter.Deserialize(userFile);
                userFile.Close();
            }
            return tempReturn;
        }

        public static Matrix4x4 TransArrayToMatrix(float[] a)
        {
            return new Matrix4x4(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15]);
        }


        public static PointWithTheta[] LoadPointCalib(string urlTool)
        {
            PointWithTheta PGet1;
            PointWithTheta PVs1;
            try
            {
                string url_PGet1 = urlTool + "\\PGet1.rtc";
                string url_PVs1 = urlTool + "\\PVs1.rtc";
                PGet1 = (PointWithTheta)LoadObjFromFile(url_PGet1);
                PVs1 = (PointWithTheta)LoadObjFromFile(url_PVs1);
            }
            catch
            {
                return null;
            }
            return new PointWithTheta[] { PGet1, PVs1 };
        }



        public static void WriteLogString(string inputString)
        {
            Dispatcher.CurrentDispatcher.BeginInvoke(new Action(delegate
            {
                MainWindow.logString.Value += inputString + "\r\n";
            }));
        }

    }

}
