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
            //cbCamList.Items.Clear();

            //foreach (string camName in Enum.GetNames(typeof(eCamName)))
            //{
            //    cbCamList.Items.Add(camName);
            //}
            cbAlignMode.DataSource = Enum.GetValues(typeof(eInspMode));
            cbEdgeLine.DataSource = Enum.GetValues(typeof(eLineKind));
            cbRecognition.DataSource = Enum.GetValues(typeof(ePatternKind));
            cbCamList.DataSource = Enum.GetValues(typeof(eCamName));

        }


        public void RecipeParamDisp()
        {
            int RcpNo = 1;
#if (NoGPT)
            if (Recipedgv.InvokeRequired)
            {
                Recipedgv.Invoke(new MethodInvoker(delegate
                {
                    Recipedgv.Rows.Clear();

                    foreach (string name in Enum.GetNames(typeof(eRecipe)))
                    {
                        Recipedgv.Rows.Add(RcpNo.ToString(), name, 0);
                        RcpNo += 1;
                    }
                }));
            }
            else
            {
                try 
                {
                    Recipedgv.Rows.Clear();
                    foreach (var name in Enum.GetNames(typeof(eRecipe)))
                    {
                        Recipedgv.Rows.Add(RcpNo.ToString(), name, 0);
                        RcpNo += 1;
                    }
                }
                catch { }
            }

#endif
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


        //private void TraceDataList(bool bDelete = false)
        //{
        //    cboTrace.Items.Clear();
        //    DirectoryInfo RawTempDirectory = new DirectoryInfo(CONST.cTracePath);
        //    if (!Directory.Exists(CONST.cTracePath)) Directory.CreateDirectory(CONST.cTracePath);
        //    FileInfo[] RawTempFile = RawTempDirectory.GetFiles("*.csv");
        //    for (int i = 0; i < RawTempFile.Length; i++)
        //    {
        //        string[] ListName = RawTempFile[i].ToString().Split('_');
        //        if ((cboTrace.Text.Trim() == ListName[0]) && bDelete)
        //        {
        //            RawTempFile[i].Delete();
        //        }
        //        else
        //        {
        //            cboTrace.Items.Add(ListName[0]);
        //        }
        //    }
        //}





    }
}
