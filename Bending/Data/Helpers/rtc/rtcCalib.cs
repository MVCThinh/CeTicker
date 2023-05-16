using Cognex.VisionPro.CalibFix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Helpers
{
    internal class rtcCalib
    {
        public List<PointWithTheta> ListAutoCalibPointsRB { get; set; }
        public List<PointWithTheta> ListAutoCalibPointsCam { get; set; }
        public int NumberPoints { get; set; }
        public CogCalibNPointToNPoint CalibNPointToolRBCam { get; set; }
        //public CogCalibNPointToNPoint CalibNPointToolRamRB { get; set; }
        public Matrix4x4 TransMatrixPOROV { get; set; }
        //public Matrix4x4 TransMatrixPOROV1 { get; set; }
        public Matrix4x4 TransformTT { get; set; }
        public Matrix4x4 TransformTT1 { get; set; }
        public Matrix4x4 TransMatrixPBASE { get; set; }
        public ICogTransform2D PointTransformToolFromNPointCalib { get; private set; }
        public bool CalNpointOK { get; set; }
        public bool CalTTMatrixOK { get; set; }
        public bool CalTTMatrixOK1 { get; set; }
        public PointWithTheta PGet1 { get; set; }
        public PointWithTheta PVs1 { get; set; }

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

        public rtcCalib()
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

        public string Command(string cmd)
        {
            switch (GetCommandId(cmd))
            {
                case "HEB":
                    RTCAutoCalibTool.ResetReceiveData();
                    AutoCalibRunning = true;
                    return "HE,1";
            }
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
