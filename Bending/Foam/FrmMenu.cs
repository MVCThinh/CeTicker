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

        private static PerformanceCounter cpuCounter;
        private static PerformanceCounter ramCounter;
        private static ComputerInfo computerInfo;


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


            pnMenu.Controls.Add(frmAutoMain);
            pnMenu.Controls.Add(frmRecipe);
            pnMenu.Controls.Add(frmHistory);
            pnMenu.Controls.Add(frmSetting);


            GetPCStatus();
            DisplayChange(btnAutoMain.Name);


            for (int i = 0; i < btnMenu.Length; i++)
            {
                btnMenu[i].Click += btnMenu_Click;
            }



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
                pnMenu.Controls[i].Visible = btnName.ToLower().Substring(3, btnName.Length - 3)
                    == pnMenu.Controls[i].Name.ToLower().Substring(2, pnMenu.Controls[i].Name.Length - 2) ? true : false;
            }
        }




        /// <summary>
        /// Lấy dung lượng ổ C, D, Ram, Cpu
        /// </summary>
        public void GetPCStatus()
        {
            cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            computerInfo = new ComputerInfo();

            // Tạo timer
            var t = new System.Windows.Forms.Timer();
            t.Interval = 3000;
            t.Enabled = true;
            t.Tick += Timer_StatusPC;

        }
        private void Timer_StatusPC(object sender, EventArgs e)
        {
            // Lấy tất cả ổ đĩa từ máy tính và sắp xếp theo tên ổ đĩa
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            Array.Sort(allDrives, (drive1, drive2) => drive1.Name.CompareTo(drive2.Name));

            // Lấy ra ổ C và ổ D
            DriveInfo cDisk = allDrives[0];
            DriveInfo dDisk = allDrives[1];

            // Lấy ra phần trăm dung lượng ổ C, D, RAM, CPU đã sử dụng
            float cpu = cpuCounter.NextValue();
            float ram = ramCounter.NextValue();

            double cPercentUse = (Convert.ToDouble(cDisk.TotalSize) - Convert.ToDouble(cDisk.AvailableFreeSpace))
                / (Convert.ToDouble(cDisk.TotalSize)) * 100;
            double dPercentUse = (Convert.ToDouble(dDisk.TotalSize) - Convert.ToDouble(dDisk.AvailableFreeSpace))
                / (Convert.ToDouble(dDisk.TotalSize)) * 100;

            double ramUse = (Convert.ToDouble(computerInfo.TotalPhysicalMemory) - Convert.ToDouble(computerInfo.AvailablePhysicalMemory))
                / (Convert.ToDouble(computerInfo.TotalPhysicalMemory)) * 100;


            // Đẩy giá trị hiển thị lên màn hình
            pgbCpu.Value = Convert.ToInt32(cpu);
            pgbRam.Value = Convert.ToInt32(ramUse);
            pgbHdc.Value = Convert.ToInt32(cPercentUse);
            pgbHdd.Value = Convert.ToInt32(dPercentUse);


            prograssbarcolor.SetState(pgbCpu, cpu > 80 ? 2 : 1);
            prograssbarcolor.SetState(pgbRam, ramUse > 80 ? 2 : 1);
            prograssbarcolor.SetState(pgbHdc, cPercentUse > 80 ? 2 : 1);
            prograssbarcolor.SetState(pgbHdd, dPercentUse > 80 ? 2 : 1);


            lbCpuP.Text = cpu.ToString("0.00") + " %";
            lbRamP.Text = ramUse.ToString("0.00") + " %";
            lbHddCP.Text = cPercentUse.ToString("0.00") + " %";
            lbHDDDP.Text = dPercentUse.ToString("0.00") + " %";


        }

        csRecipe csRecipe = new csRecipe();
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (old_rcpName != csRecipe.RecipeName)
            {

            }
        }
    }






    /// <summary>
    /// Thanh ProgressBar
    /// </summary>
    public static class prograssbarcolor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);

        /// <summary>
        ///  1: "hoạt động" (normal).
        /// 2:  "đang tạm dừng" (paused).
        /// 3:  "lỗi" (error).
        /// 4:  "hoàn thành" (complete).
        /// </summary>
        /// <param name="pBar">trạng thái</param>
        /// <param name="state"></param>
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
