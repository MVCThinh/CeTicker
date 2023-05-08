using Bending.Properties;
using Bending.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


        private Button[] btnMenu;
        public Menu()
        {
            InitializeComponent();
            lbProgramVer.Text = "Ver 08.05.2023";
            btnMenu = new Button[] { btnAutoMain, btnRecipe, btnSetting, btnHistory };


            pnMenu.Controls.Add(frmAutoMain);
            pnMenu.Controls.Add(frmRecipe);
            pnMenu.Controls.Add(frmHistory);
            pnMenu.Controls.Add(frmSetting);

            DisplayChange(btnAutoMain.Name);

            for (int i = 0; i < btnMenu.Length; i++)
            {
                btnMenu[i].Click += btnMenu_Click;
            }
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            string btnText = (sender as Button).Text;

            for (int i = 0; i < btnMenu.Length; i++)
            {
                if (btnText == btnMenu[i].Text)
                {
                    DisplayChange(btnMenu[i].Name);
                    btnMenu[i].ForeColor = Color.Yellow;
                }
                else
                    btnMenu[i].ForeColor = Color.White;
            }
        }

        private void DisplayChange(string btnName)
        {
            for (int i = 0; i < pnMenu.Controls.Count; i++)
            {
                if (btnName.ToLower().Substring(3, btnName.Length - 3) == pnMenu.Controls[i].Name.ToLower().Substring(2, pnMenu.Controls[i].Name.Length - 2))
                {
                    pnMenu.Controls[i].Visible = true;

                }
                else
                    pnMenu.Controls[i].Visible = false;
            }
        }
    }
}
