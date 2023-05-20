using Bending.Data.Enums;
using Bending.Data.Helpers;
using Bending.Data.Models.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bending.UC
{
    public partial class ucRecipe : UserControl
    {


        public static VisionPro LoadingPre1 = new VisionPro();
        public static VisionPro LoadingPre2 = new VisionPro();
        public static VisionPro Laser1 = new VisionPro();
        public static VisionPro Laser2 = new VisionPro();

        public static VisionPro[] AllCam = new VisionPro[]
        {
            LoadingPre1,
            LoadingPre2,
            Laser1,
            Laser2
        };


        


        public ucRecipe()
        {
            InitializeComponent();


            LoadDisplay();
            RecipeParamDisp();

            VisionPro.GetConnectedCameras(); // Lấy đc 4 cam và tạo đc AcqFifoTool.Operator

        }

        
        private void LoadDisplay()
        {

            cbAlignMode.DataSource = Enum.GetValues(typeof(eInspMode));
            cbEdgeLine.DataSource = Enum.GetValues(typeof(eLineKind));
            cbRecognition.DataSource = Enum.GetValues(typeof(ePatternKind));
            cbCamList.DataSource = Enum.GetValues(typeof(eCamName));

        }


        public void RecipeParamDisp()
        {
            int RcpNo = 1;

            Recipedgv.BeginInvoke(new MethodInvoker(delegate
            {
                Recipedgv.Rows.Clear();

                foreach (string name in Enum.GetNames(typeof(eRecipe)))
                {
                    Recipedgv.Rows.Add(RcpNo.ToString(), name, 0);
                    RcpNo++;
                }
            }));

        }

        private void cbCamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            TriggerOrLiveCamSetting(false);
        }

        private VisionPro GetCamSettingByCamName(eCamName camName)
        {
            switch (camName)
            {
                case eCamName.LoadingPre1:
                    return LoadingPre1;
                case eCamName.LoadingPre2:
                    return LoadingPre2;
                case eCamName.Laser1:
                    return Laser1;
                case eCamName.Laser2:
                    return Laser2;
                default:
                    return null;
            }
        }


        private void TriggerOrLiveCamSetting(bool isLive)
        {
            eCamName camName = (eCamName)cbCamList.SelectedItem;
            VisionPro cam = GetCamSettingByCamName(camName);

            cogDS.InteractiveGraphics.Clear();
            cogDS2.InteractiveGraphics.Clear();

            if (cam != null)
            {
                // Cam LoadingPre1 or LoadingPre2 
                if (camName == eCamName.LoadingPre1 || camName == eCamName.LoadingPre2)
                {
                    
                }
                else
                {

                }
            }
        }





        private void btnLiveImage_Click(object sender, EventArgs e)
        {
            TriggerOrLiveCamSetting(true);
        }



        private void btnCal_Click(object sender, EventArgs e)
        {
            if (tmrCal.Enabled)
            {
                MessageBox.Show("Calibraition is not Finished");
                return;
            }
        }

        List<Point> lstRobotPoint= new List<Point>();
        List<Point> lstVisionPoint= new List<Point>();



        private void tmrCal_Tick(object sender, EventArgs e)
        {


        }
    }
}
