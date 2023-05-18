using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.AutoCalib
{
    public class AutoCalib
    {
        public static PointWithTheta[] listPointRB = new PointWithTheta[11];
        public static PointWithTheta[] listPointCam = new PointWithTheta[11];





        private void Calib9Point()
        {

        }

    }

    public class PointWithTheta
    {
        public PointWithTheta(float pointX, float pointY, float pointTheta)
        {
            this.pointX = pointX;
            this.pointY = pointY;
            this.pointTheta = pointTheta;
        }

        public float pointX { get; set; }
        public float pointY { get; set; }
        public float pointTheta { get; set; }
    }

}
