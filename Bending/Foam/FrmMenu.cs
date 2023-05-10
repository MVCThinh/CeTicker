using Bending.Data.Enums;
using Bending.Data.Helpers;
using Bending.Properties;
using Bending.UC;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bending
{
    public partial class Menu : Form
    {

        public static ucAutoMain frmAutoMain = new ucAutoMain();
        public static ucHistory frmHistory = new ucHistory();
        public static ucRecipe frmRecipe = new ucRecipe();
        public static ucSetting frmSetting = new ucSetting();





        public static string PathToFolderINI;

        private string old_rcpName = "";


        private Button[] btnMenu;
        public Menu()
        {
            InitializeComponent();



            lbProgramVer.Text = "Ver 08.05.2023";
            btnMenu = new Button[] { btnAutoMain, btnRecipe, btnSetting, btnHistory };


            //pnMenu.Controls.Add(frmAutoMain);
            //pnMenu.Controls.Add(frmRecipe);
            //pnMenu.Controls.Add(frmHistory);
            //pnMenu.Controls.Add(frmSetting);

            pnMenu.Controls.AddRange(new Control[] { frmAutoMain, frmHistory, frmRecipe, frmSetting });


            GetPCStatus();
            DisplayChange(btnAutoMain.Name);


            //for (int i = 0; i < btnMenu.Length; i++)
            //{
            //    btnMenu[i].Click += btnMenu_Click;
            //}

            Array.ForEach(btnMenu, btn => btn.Click += btnMenu_Click);



        }

        private void LoadFolderPathRoot()
        {
            // path là thư mực ../Bending
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName; 
            //PathToFolderINI = Path.Combine(path, )
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            string btnText = (sender as Button).Text;

            //for (int i = 0; i < btnMenu.Length; i++)
            //{
            //    if (btnText == btnMenu[i].Text)
            //    {
            //        DisplayChange(btnMenu[i].Name);
            //        btnMenu[i].ForeColor = Color.Yellow;
            //    }
            //    else
            //        btnMenu[i].ForeColor = Color.White;
            //}

            foreach (Button btn in btnMenu)
            {
                if (btnText == btn.Text)
                {
                    DisplayChange(btn.Name);
                    btn.ForeColor = Color.Yellow;
                }
                else
                    btn.ForeColor = Color.White;
            }    

        }

        private void DisplayChange(string btnName)
        {
            //for (int i = 0; i < pnMenu.Controls.Count; i++)
            //{
            //    pnMenu.Controls[i].Visible = btnName.ToLower().Substring(3, btnName.Length - 3)
            //        == pnMenu.Controls[i].Name.ToLower().Substring(2, pnMenu.Controls[i].Name.Length - 2) ? true : false;
            //}

            pnMenu.Controls.Cast<Control>().ToList().ForEach(control =>
            {
                control.Visible = btnName.ToLower().Substring(3) == control.Name.ToLower().Substring(2);
            });

        }






        csRecipe csRecipe = new csRecipe();
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (old_rcpName != csRecipe.RecipeName)
            {

            }
        }
    }







}
