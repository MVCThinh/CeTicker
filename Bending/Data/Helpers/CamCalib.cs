using Bending.Data.Enums;
using Bending.Data.Helpers;
using Bending.Data.Models;
using Bending.Data.Static;
using Bending.UC;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bending.Data.Class
{
    public class CamCalib
    {

       // public PointXY[] lstRobotPoint { get; set; }

        public void SetRobotPos(double RobotX , double RobotY, ref PointXY[] lstRobot)
        {
            RobotX = Math.Abs(RobotX);
            RobotY = Math.Abs(RobotY);
            lstRobot = new PointXY[9];

            for (int i = 0; i < lstRobot.Length; i++)
            {
                int xIndex = i % 3;
                int yIndex = i / 3;

                lstRobot[i].X = (xIndex == 0) ? (RobotX * -1.0) : ((xIndex == 2) ? RobotX : 0.0);
                lstRobot[i].Y = (yIndex == 0) ? RobotY : ((yIndex == 2) ? (RobotY * -1.0) : 0.0);
            }

        }




    }

    public class PointXY
    {
        public double X { get; set; }
        public double Y { get; set; }

        public PointXY(double tX, double tY)
        {
            X= tX;
            Y= tY;
        }
    }
}
