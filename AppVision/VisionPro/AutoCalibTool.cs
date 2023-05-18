using Cognex.VisionPro;
using Cognex.VisionPro.CalibFix;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppVision.VisionPro
{
    public class AutoCalibTool
    {
        public List<PointWithTheta> ListAutoCalibPointsRB { get; set; }
        public List<PointWithTheta> ListAutoCalibPointsCam { get; set; }
        public CogCalibNPointToNPoint CalibNPointToolRBCam { get; set; }
        public ICogTransform2D PointTransformToolFromNPointCalib { get; private set; }
        public bool CalNpointOK { get; set; }
        public bool CalTTMatrixOK { get; set; }
        public bool CalTTMatrixOK1 { get; set; }
        public int NumberPoints { get; set; }
        public Matrix4x4 TransMatrixPOROV { get; set; }
        public Matrix4x4 TransformTT { get; set; }
        public Matrix4x4 TransformTT1 { get; set; }
        public Matrix4x4 TransMatrixPBASE { get; set; }

        public PointWithTheta PGet1 { get; set; }
        public PointWithTheta PVs1 { get; set; }


        public AutoCalibTool()
        {
            ListAutoCalibPointsRB = new List<PointWithTheta>();
            ListAutoCalibPointsCam = new List<PointWithTheta>();

            CalibNPointToolRBCam = new CogCalibNPointToNPoint();
            PointTransformToolFromNPointCalib = null;

            CalNpointOK = false;
            CalTTMatrixOK = false;
            CalTTMatrixOK1 = false;

            NumberPoints = 0;
        }

        public void ResetReceiveData()
        {
            ListAutoCalibPointsRB.Clear();
            ListAutoCalibPointsCam.Clear();
            CalibNPointToolRBCam = new CogCalibNPointToNPoint();
            PointTransformToolFromNPointCalib = null;
            CalNpointOK = false;
            CalTTMatrixOK = false;
            CalTTMatrixOK1 = false;
            NumberPoints = 0;
        }

        public void AddPoint(PointWithTheta tempCamPoint, PointWithTheta tempRobotPoint)
        {
            ListAutoCalibPointsRB.Add(tempRobotPoint);
            ListAutoCalibPointsCam.Add(tempCamPoint);
            NumberPoints += 1;
        }

        public bool CalculateNPoint()
        {
            // Tính toán ma trận chuyển hệ Robot sang hệ Camera POROV TransformMatrixPOROV
            if (NumberPoints >= 11)
            {
                for (int i = 0; i < 9; i++)
                {
                    CalibNPointToolRBCam.AddPointPair(ListAutoCalibPointsRB[i].X, ListAutoCalibPointsRB[i].Y, ListAutoCalibPointsCam[i].X, ListAutoCalibPointsCam[i].Y);
                }
                CalibNPointToolRBCam.Calibrate();
                if (!CalibNPointToolRBCam.Calibrated)
                {
                    MessageBox.Show("N Point Calib Fail!");
                    return false;
                }
                else
                {

                    PointTransformToolFromNPointCalib = CalibNPointToolRBCam.GetComputedUncalibratedFromCalibratedTransform();
                    PointWithTheta pointCam9 = Helper.TransPointFromNPoint(PointTransformToolFromNPointCalib, ListAutoCalibPointsCam[9]);
                    PointWithTheta pointCam10 = Helper.TransPointFromNPoint(PointTransformToolFromNPointCalib, ListAutoCalibPointsCam[10]);
                    var tempArrMatrix = TransformMatrixCal.CalPBaseAndPOROC1(ListAutoCalibPointsRB[9], ListAutoCalibPointsRB[10], pointCam9, pointCam10);
                    TransMatrixPOROV = tempArrMatrix[1];
                    TransMatrixPBASE = tempArrMatrix[0];
                    CalNpointOK = true;
                }
            }
            return true;
        }

        /// <summary>
        /// Tính toán TT
        /// Lấy điểm Input từ Robot
        /// Chuyển đổi từ điểm Align Camera qua Tool chuyển NPoint
        /// Tính toán từ 2 điểm trên ra ma trận TT
        /// </summary>
        /// <param name="cmd"></param>
        /// 
        public void CalTTTransMatrixPoint(string cmd, PointWithTheta alignPoint)
        {
            //float XPg1 = 260;
            //float YPg1 = 200;
            //float ThetaPg1 = 0;

            //float XPvs1 = 300;
            //float YPvs1 = 200;
            //float ThetaPvs1 = (float)(71.5651 * Math.PI / 180);


            //alignPoint = new PointWithTheta(XPvs1, YPvs1, ThetaPvs1);
            //PGet1 = new PointWithTheta(XPg1, YPg1, ThetaPg1);
            //PVs1 = alignPoint;
            PGet1 = Helper.GetRobotPointFromCmd(cmd);
            PVs1 = Helper.TransPointFromNPoint(PointTransformToolFromNPointCalib, alignPoint);
            //PVs1 = alignPoint;
            CalTTMatrixOK = true;
        }

        public void Load(int CameraIndex)
        {
            string[] writeStrings = new string[10];
            string urlTool = Helper.CreatDirectionAutoCalib(CameraIndex);
            // 
            if (File.Exists(urlTool + "\\info.txt"))
            {
                string[] readString = File.ReadAllLines(urlTool + "\\info.txt");
                foreach (string item in readString)
                {
                    if (item.IndexOf("CalNpointOK,") >= 0) CalNpointOK = bool.Parse(item.Split(',')[1]);
                    if (item.IndexOf("CalTTMatrixOK,") >= 0) CalTTMatrixOK = bool.Parse(item.Split(',')[1]);
                }
            }
            else
            {
                CalNpointOK = false;
                CalTTMatrixOK = false;
            }
            //
            if (CalNpointOK && CalTTMatrixOK)
            {
                Matrix4x4[] tempArrMatrix = Helper.LoadAutoCalibMatrix(urlTool);
                if (tempArrMatrix != null)
                {
                    TransMatrixPBASE = tempArrMatrix[0];
                    TransformTT = tempArrMatrix[1];
                    TransMatrixPOROV = tempArrMatrix[2];
                }
                PointWithTheta[] tempPoint = Helper.LoadPointCalib(urlTool);
                if (tempPoint != null)
                {
                    PGet1 = tempPoint[0];
                    PVs1 = tempPoint[1];
                }
            }
            if (CalNpointOK && CalTTMatrixOK)
            {
                Matrix4x4[] tempArrMatrix = Helper.LoadAutoCalibMatrix1(urlTool);
                if (tempArrMatrix != null)
                {
                    TransMatrixPBASE = tempArrMatrix[0];
                    TransformTT1 = tempArrMatrix[1];
                    TransMatrixPOROV = tempArrMatrix[2];
                }
            }
            //
            if (File.Exists(urlTool + "\\CalibNPointToolRBCam.vpp"))
                CalibNPointToolRBCam = (CogCalibNPointToNPoint)Cognex.VisionPro.CogSerializer.LoadObjectFromFile(urlTool + "\\CalibNPointToolRBCam.vpp", typeof(System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), CogSerializationOptionsConstants.All);
            PointTransformToolFromNPointCalib = CalibNPointToolRBCam.GetComputedUncalibratedFromCalibratedTransform();
        }

    }

    public class PointWithTheta
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Theta { get; set; }

        public PointWithTheta()
        {
            X = 0; Y = 0; Theta = 0;
        }
        public PointWithTheta(float tX, float tY, float tTheta)
        {
            X = tX;
            Y = tY;
            Theta = tTheta;
        }
    }
}
