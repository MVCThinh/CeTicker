using Bending.Data.Helpers;
using Cognex.VisionPro.ID;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bending.UC
{
    public partial class ucAutoMain : UserControl
    {
        public csVision[] Visions { get; set; }

        public ucAutoMain()
        {
            InitializeComponent();
            Visions = new csVision[4];
          //  InitialVison();
        }



        private void InitialVison()
        {
            try
            {
                for (int i = 0; i< Visions.Length; i++)
                {
                    Visions[i].bCamSerialCheck = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        public void CreateListParaDesgin()
        {

        }

    }
}
