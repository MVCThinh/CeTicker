using Bending.UC;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bending
{
    public partial class Menu :Form
    {

        private static PerformanceCounter cpuCounter;
        private static PerformanceCounter ramCounter;
        private static ComputerInfo computerInfo;


        public static string PATH_BASE = @"C:\EQData";
        public static string PATH_SYSTEM = "\\Calibration";
        public static string PATH_DATA = "\\Data";
        public static string PATH_DUMMY = "\\";
        public static string FILE_CALIBRATION = "Calibration";
        public static string Adjust_FILE_CALIBRATION = "Adjust";
        public static string EXTENSION_DAT = ".dat";




        /// <summary>
        /// Lấy dung lượng ổ C, D, Ram, Cpu
        /// </summary>
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

    /// <summary>
    /// Thanh ProgressBar
    /// </summary>
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
