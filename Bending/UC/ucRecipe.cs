using Bending.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public ucRecipe()
        {
            InitializeComponent();


            Initial();
            RecipeParamDisp();
        }

        
        private void Initial()
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







    }
}
