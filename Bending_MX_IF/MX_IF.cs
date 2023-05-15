using Bending.Data.Helpers;
using Bending_MX_IF.Data;
using Bending_MX_IF.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bending_MX_IF
{
    public partial class MXIF : Form
    {
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        [DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "ageage")]
        public static extern int SendMessage(IntPtr hWnd, Int32 Msg, IntPtr wParam, ref Win32API.COPYDATASTRUCT lParam);

        [DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, Int32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        // Tương tác truyền dữ liệu giữa 2 ứng dụng 


        public static DeviceSetting deviceSetting = new DeviceSetting();
        public static PCBit pcBit = new PCBit();
        public static PLCBit plcBit = new PLCBit();





        public MXIF()
        {
            InitializeComponent();

            LoadConfig();
            Initial();
            
        }

        private void Initial()
        {
            FFU.Open();
        }



        private void LoadConfig()
        {
            RWFile.RWFilePath = @"C:\EQData1\Config\Config.ini";
            string Section = "DEVICE";

            lbVersion.Text = RWFile.ReadFile(Section, "SWVersion");

            deviceSetting.PLCType = int.Parse(RWFile.ReadFile(Section, "PLCType"));
            deviceSetting.PLCDevice = RWFile.ReadFile(Section, "PLCDevice");
            deviceSetting.PLCIP = RWFile.ReadFile(Section, "PLCIP");

            deviceSetting.StationNO = int.Parse(RWFile.ReadFile(Section, "StationNO"));
            deviceSetting.NetworkNO = int.Parse(RWFile.ReadFile(Section, "NetworkNO"));

            deviceSetting.GPSIP = RWFile.ReadFile(Section, "GPSIP");
            deviceSetting.UPSIP = RWFile.ReadFile(Section, "UPSIP");

            deviceSetting.FFU_CNT = int.Parse(RWFile.ReadFile(Section, "FFU_CNT", "10"));

            Section = "PLCBIT";

            plcBit.BITCONTROL = int.Parse(RWFile.ReadFile(Section, "BITCONTROL"));
            plcBit.MOVEREPLY = int.Parse(RWFile.ReadFile(Section, "MOVEREPLY"));
            plcBit.CHANGETIME = int.Parse(RWFile.ReadFile(Section, "CHANGETIME"));
            plcBit.PLC_CAL_MOVE = int.Parse(RWFile.ReadFile(Section, "PLC_CAL_MOVE"));

            plcBit.CELLID1 = int.Parse(RWFile.ReadFile(Section, "CELLID1"));
            plcBit.CELLID2 = int.Parse(RWFile.ReadFile(Section, "CELLID2"));
            plcBit.CELLID3 = int.Parse(RWFile.ReadFile(Section, "CELLID3"));
            plcBit.CELLID4 = int.Parse(RWFile.ReadFile(Section, "CELLID4"));
            plcBit.CELLID5 = int.Parse(RWFile.ReadFile(Section, "CELLID5"));
            plcBit.CELLID6 = int.Parse(RWFile.ReadFile(Section, "CELLID6"));
            plcBit.CELLID7 = int.Parse(RWFile.ReadFile(Section, "CELLID7"));
            plcBit.CELLID8 = int.Parse(RWFile.ReadFile(Section, "CELLID8"));

            Section = "PCBIT";

            pcBit.BITCONTROL = int.Parse(RWFile.ReadFile(Section, "BITCONTROL"));
            pcBit.CALIBRATION = int.Parse(RWFile.ReadFile(Section, "CALIBRATION"));
            pcBit.REPLY = int.Parse(RWFile.ReadFile(Section, "REPLY"));
            pcBit.PC_CAL_MOVE = int.Parse(RWFile.ReadFile(Section, "PC_CAL_MOVE"));

            pcBit.FFU = int.Parse(RWFile.ReadFile(Section, "FFU"));
            pcBit.GMS = int.Parse(RWFile.ReadFile(Section, "GMS"));
            pcBit.UPS = int.Parse(RWFile.ReadFile(Section, "UPS"));
            pcBit.GPS = int.Parse(RWFile.ReadFile(Section, "GPS"));

        }


        private void FFUData2(List<byte> Msg)
        {
            try
            {
                for (int i = 0; i < deviceSetting.FFU_CNT; i++)
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FFU_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int dataLength = FFU.BytesToRead;
            byte[] bytes= new byte[dataLength];
            FFU.Read(bytes, 0, dataLength);

            List<byte> receiveData = new List<byte>();

            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] == 0x02)  // STX
                { 
                    receiveData.Clear();
                }
                else if (bytes[i] == 0x03) // ETX
                {
                    if (receiveData.Count > 0)
                    {
                        FFUData2(receiveData);
                        receiveData.Clear ();
                    }
                }
                else
                {
                    receiveData.Add(bytes[i]);
                    if (receiveData.Count > 1000)
                    {
                        receiveData.Clear();
                    }
                        
                }
            }

        }
    }

    public static class Win32API
    {
        public const Int32 WM_COPYDATA = 0x004A;

        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;

            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }
    }

}
