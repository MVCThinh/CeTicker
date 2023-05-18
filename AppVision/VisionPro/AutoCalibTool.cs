using Cognex.VisionPro;
using Cognex.VisionPro.CalibFix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
