using Bending.Data.Helpers;
using Bending_MX_IF.Data;
using Bending_MX_IF.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bending_MX_IF
{
    public partial class MXIF : Form
    {

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

        private ACTETHERLib.ActQJ71E71TCP actIF = new ACTETHERLib.ActQJ71E71TCP();


        private IntPtr hwnd;


        public MXIF()
        {
            InitializeComponent();

            LoadConfig();
            Initial();

            if (Connection() == 0)
                tmrIF.Enabled = true;

        }

        public bool bCalIF;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case Win32API.WM_COPYDATA:
                    Win32API.COPYDATASTRUCT cds1 = (Win32API.COPYDATASTRUCT)m.GetLParam(typeof(Win32API.COPYDATASTRUCT));
                    lbMain.Items.Add(cds1.lpData);

                    label5.BackColor = Color.Aqua;
                    if (lbMain.Items.Count > 100) lbMain.Items.Clear();

                    string[] sData = cds1.lpData.Split(new char[] { ',' });
                    if (sData[0] == "*1")  // Request Data
                    {
                        hwnd = IntPtr.Zero;
                        tmrIF.Enabled = true;
                       // cConfig.Vision_Init = true;
                    }
                    else if (sData[0] == "*2")  // Cal Reply Data
                    {
                        if (sData[2] == "1")
                        {
                            bCalIF = true;
                        }
                        else bCalIF = false;
                    }
                    else if (sData[0] == "RCPID")
                    {
                        short sLength = 20;
                        string rcpID = StringRecive(sData[1], sLength);   // Recipe ID Read
                        SendData(sData[0] + "," + rcpID);
                    }
                    else if (sData[0] == "RCPPARAM")
                    {
                        short sLength = 150;
                        int[] iData = new int[sLength * 2];
                        actIF.ReadDeviceBlock(sData[1], sLength * 2, out iData[0]);

                        string reply = "";
                        for (int i = 0; i < sLength; i++)
                        {
                            if (i < (sLength * 2 - 1)) reply = reply + iData[2 * i].ToString() + "," + iData[2 * i + 1].ToString() + ",";
                            else reply = reply + iData[2 * i].ToString() + "," + iData[2 * i + 1].ToString();
                        }
                        SendData(sData[0] + "," + reply);
                    }
                    else if (sData[0] == "CALDATAREAD")
                    {
                        short sLength = 62;
                        int[] iData = new int[sLength * 2];
                        actIF.ReadDeviceBlock(deviceSetting.PLCDevice + plcBit.PLC_CAL_MOVE, sLength * 2, out iData[0]);

                        string reply = "";
                        for (int i = 0; i < sLength; i++)
                        {
                            if (i < (sLength - 1)) reply = reply + iData[2 * i].ToString() + "," + iData[2 * i + 1].ToString() + ",";
                            else reply = reply + iData[2 * i].ToString() + "," + iData[2 * i + 1].ToString();
                        }
                        SendData(sData[0] + "," + reply);
                        iData[0] = 1;
                        actIF.WriteDeviceBlock(deviceSetting.PLCDevice + (pcBit.PC_CAL_MOVE + 2), 1, ref iData[0]) ;
                    }
                    else if (sData[0] == "CALDATAMOVE")
                    {
                        int iData = 1;
                        actIF.WriteDeviceBlock(deviceSetting.PLCDevice + pcBit.PC_CAL_MOVE, 1, ref iData);
                    }
                    else if (sData[0].IndexOf("POSITION") >= 0)
                    {
                        short sLength = short.Parse(sData[2]);
                        int[] iData = new int[sLength * 2];
                        actIF.ReadDeviceBlock(sData[1], sLength * 2, out iData[0]);

                        string reply = "";
                        for (int i = 0; i < sLength; i++) //sLength * 2 -> sLength 변경 2018.07.26 khs
                        {
                            if (i < (sLength * 2 - 1)) reply = reply + iData[2 * i].ToString() + "," + iData[2 * i + 1].ToString() + ",";
                            else reply = reply + iData[2 * i].ToString() + "," + iData[2 * i + 1].ToString();
                        }
                        SendData(sData[0] + "," + reply);
                    }
                    else if (sData[0].IndexOf("BENDPRE") == 0)
                    {
                        short sLength = short.Parse(sData[2]);
                        int[] iData = new int[sLength * 2];
                        actIF.ReadDeviceBlock(sData[1], sLength * 2, out iData[0]);

                        string reply = "";
                        for (int i = 0; i < sLength; i++)
                        {
                            if (i < (sLength * 2 - 1)) reply = reply + iData[2 * i].ToString() + "," + iData[2 * i + 1].ToString() + ",";
                            else reply = reply + iData[2 * i].ToString() + "," + iData[2 * i + 1].ToString();
                        }
                        SendData(sData[0] + "," + reply);
                    }
                    else if (sData[0].IndexOf("TrOffset") == 0)
                    {
                        short sLength = short.Parse(sData[2]);
                        int[] iData = new int[sLength * 2];
                        actIF.ReadDeviceBlock(sData[1], sLength * 2, out iData[0]);

                        string reply = "";
                        for (int i = 0; i < sLength; i++)
                        {
                            if (i < (sLength * 2 - 1)) reply = reply + iData[2 * i].ToString() + "," + iData[2 * i + 1].ToString() + ",";
                            else reply = reply + iData[2 * i].ToString() + "," + iData[2 * i + 1].ToString();
                        }
                        SendData(sData[0] + "," + reply);
                    }
                    else if (sData[0] == "PNID")
                    {
                        //20.10.16 lkw 40 word 변경함.
                        short sLength = 40;
                        //if (sData[1] == "I1" || sData[1] == "I2" || sData[1] == "H1") sLength = 24;
                        string sPnData = StringRecive(sData[2], sLength);   //쓰레기 값 들어오는거때문에 24->20으로 변경
                        SendData(sData[0] + "," + sData[1] + "," + sPnData);
                    }

                    else if (sData[0] == "LaserSendCellID") //210118 cjm 레이저 로그
                    {
                        short sLength = 100;
                        string sPnData = StringRecive(sData[2], sLength);
                        SendData(sData[0] + "," + sData[1] + "," + sPnData);
                    }
                    else if (sData[0] == "MCRCellID")  //210118 cjm 레이저 로그
                    {
                        short sLength = 100;
                        string sPnData = StringRecive(sData[2], sLength);
                        SendData(sData[0] + "," + sData[1] + "," + sPnData);
                    }
                    else if (sData[0] == "TIME")
                    {
                        short sLength = 14;
                        string timeData = StringRecive(sData[1], sLength);
                        SendData(sData[0] + "," + timeData);
                    }


                    else if (sData.Length > 2 && sData[2].IndexOf("^") > 0)   //Data가 ^으로 구분된 경우
                    {
                        string[] DataValue = sData[2].Split(new char[] { '^' });
                        int[] iData = new int[DataValue.Length];
                        for (int i = 0; i < DataValue.Length; i++)
                        {
                            iData[i] = (int)(double.Parse(DataValue[i]));
                        }
                        actIF.WriteDeviceBlock(sData[0], int.Parse(sData[1]), ref iData[0]);
                        //mxLogwrite(sData[0] + "," + sData[1] + "," + sData[2]);
                    }
                    else if (sData[0].IndexOf("ZR") == 0)                                                 //Data가 , 로 구분된 경우 (1Word)
                    {
                        int[] iData = new int[sData.Length - 2];
                        for (int i = 0; i < iData.Length; i++)
                        {
                            iData[i] = int.Parse(sData[i + 2]);
                        }

                        actIF.WriteDeviceBlock(sData[0], int.Parse(sData[1]), ref iData[0]);
                        //mxLogwrite(sData[0] + "," + sData[1] + "," + sData[2]);
                    }
                    else if (sData[0].IndexOf("READZR") == 0)                                                 //Data가 , 로 구분된 경우 (1Word)
                    {
                        short sLength = short.Parse(sData[3]);
                        int[] iData = new int[sLength * 2];
                        actIF.ReadDeviceBlock(sData[2], sLength * 2, out iData[0]);

                        string reply = "";
                        for (int i = 0; i < sLength; i++)
                        {
                            if (i < (sLength * 2 - 1)) reply = reply + iData[2 * i].ToString() + "," + iData[2 * i + 1].ToString() + ",";
                            else reply = reply + iData[2 * i].ToString() + "," + iData[2 * i + 1].ToString();
                        }
                        SendData(sData[0] + "," + sData[1] + "," + reply);
                    }

                    break;
                default : break;

            }
            base.WndProc(ref m);    
        }


        private void tmrIF_Tick(object sender, EventArgs e)
        {
            if (hwnd == IntPtr.Zero)
                hwnd = FindWindow(null, "BD_IF");

        }


        private void Initial()
        {
            FFU.Open();
        }

        private int Connection()
        {
            actIF.ActConnectUnitNumber = 0;
            actIF.ActCpuType = deviceSetting.PLCType;
            actIF.ActDestinationPortNumber = 0;
            actIF.ActDestinationPortNumber = 5002;
            actIF.ActDidPropertyBit = 1;
            actIF.ActHostAddress = deviceSetting.PLCIP;
            actIF.ActIONumber = 1023;
            actIF.ActMultiDropChannelNumber = 0;
            actIF.ActNetworkNumber = deviceSetting.NetworkNO;
            actIF.ActSourceNetworkNumber = deviceSetting.NetworkNO;
            actIF.ActSourceStationNumber = deviceSetting.StationNO;
            actIF.ActStationNumber = 1;
            actIF.ActTimeOut = 3000;
            actIF.ActUnitNumber = 0;

            return actIF.Open();
        }

        public string StringRecive(string start, short DataSize)
        {
            string rcvData = "";
            try
            {
                ASCIIEncoding Ascii = new ASCIIEncoding();
                short lcDataSize = (short)(DataSize);
                //de_type = 24;
                int[] lcRcvData = new int[lcDataSize];
                actIF.ReadDeviceBlock(start, DataSize, out lcRcvData[0]);

                for (int i = 0; i < lcDataSize / 2; i++)
                {
                    byte[] lcTemp = new byte[2];
                    lcTemp[0] = (byte)(lcRcvData[i] & 0xFF);
                    lcTemp[1] = (byte)((lcRcvData[i] & 0xFF00) / 0x100);

                    if (lcTemp[0] == 0) lcTemp[0] = 0x20;
                    if (lcTemp[1] == 0) lcTemp[1] = 0x20;

                    rcvData = rcvData + Ascii.GetString(lcTemp);
                }
                return rcvData;
            }
            catch (Exception)
            {
                //LOG.ExceptionLogSave("StringRecive" + "," + EX.GetType().Name + "," + EX.Message);
                return rcvData;
            }
        }




        private void SendData(string Msg)
        {
            if (hwnd == IntPtr.Zero)
            {
                hwnd = FindWindow(null, "BD_IF");
            }
            if (hwnd != IntPtr.Zero)
            {
                IntPtr msgPtr = Marshal.StringToHGlobalAnsi(Msg); // CHuyển đổi chuỗi thành con trỏ IntPtr
                try
                {
                    SendMessage(hwnd, Win32API.WM_COPYDATA, IntPtr.Zero, msgPtr);
                    SetlbMXLabel(Msg);
                    if (lbMX.Items.Count > 100) lbMX.Items.Clear();
                }
                finally
                {
                    Marshal.FreeHGlobal(msgPtr); // Giải phóng con trỏ
                }
            }
        }


        private void SetlbMXLabel(string Msg)
        {

            lbMX.BeginInvoke(new Action(() =>
            {
                if (lbMX.Items.Count > 100) lbMX.Items.Clear();

                lbMX.Items.Add(Msg);
            }));
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
            byte[] bytes = new byte[dataLength];
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
                        receiveData.Clear();
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
