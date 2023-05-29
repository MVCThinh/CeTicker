using Bending.Data.Enums;
using Bending.Data.Helpers;
using Bending.Data.Models.Setting;
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

        private static PerformanceCounter cpuCounter;
        private static PerformanceCounter ramCounter;
        private static ComputerInfo computerInfo;


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

            pnMenu.Controls.AddRange(new Control[] { frmAutoMain, frmHistory, frmRecipe, frmSetting });


            GetPCStatus();
            DisplayChange(btnAutoMain.Name);


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

            pnMenu.Controls.Cast<Control>().ToList().ForEach(control =>
            {
                control.Visible = btnName.ToLower().Substring(3) == control.Name.ToLower().Substring(2);
            });

        }



        public void GetPCStatus()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            computerInfo = new ComputerInfo();

            var t = new System.Windows.Forms.Timer();
            t.Interval = 3000;
            t.Enabled = true;
            t.Tick += Timer_StatusPC;

        }
        private void Timer_StatusPC(object sender, EventArgs e)
        {

            DriveInfo[] allDrives = DriveInfo.GetDrives();
            DriveInfo cDisk = allDrives.FirstOrDefault(drive => drive.Name.Equals(@"C:\"));
            DriveInfo dDisk = allDrives.FirstOrDefault(drive => drive.Name.Equals(@"D:\"));

            double cPercentUse = (cDisk.TotalSize - cDisk.AvailableFreeSpace) / (double)cDisk.TotalSize * 100;
            double dPercentUse = (dDisk.TotalSize - dDisk.AvailableFreeSpace) / (double)dDisk.TotalSize * 100;

            double cpu = cpuCounter.NextValue();
            double ramUse = (computerInfo.TotalPhysicalMemory - computerInfo.AvailablePhysicalMemory) / (double)computerInfo.TotalPhysicalMemory * 100;

            pgbCpu.Value = (int)cpu;
            pgbRam.Value = (int)ramUse;
            pgbHdc.Value = (int)cPercentUse;
            pgbHdd.Value = (int)dPercentUse;

            prograssbarcolor.SetState(pgbCpu, cpu > 80 ? 2 : 1);
            prograssbarcolor.SetState(pgbRam, ramUse > 80 ? 2 : 1);
            prograssbarcolor.SetState(pgbHdc, cPercentUse > 80 ? 2 : 1);
            prograssbarcolor.SetState(pgbHdd, dPercentUse > 80 ? 2 : 1);

            lbCpuP.Text = $"{cpu:0.00} %";
            lbRamP.Text = $"{ramUse:0.00} %";
            lbHddCP.Text = $"{cPercentUse:0.00} %";
            lbHDDDP.Text = $"{dPercentUse:0.00} %";


        }

    }
    public static class prograssbarcolor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);

        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }

}
