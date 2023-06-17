using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bending.Foam
{
    public partial class frmPLC : Form
    {

        private ActUtlTypeLib.ActUtlType plc = new ActUtlTypeLib.ActUtlType();
        public frmPLC()
        {
            InitializeComponent();

            Load();
        }

        private void Load()
        {
            plc.ActLogicalStationNumber = 0;


            int b = plc.Open();

            lbConnect.Text = b == 0 ? "Connected" : "Disconnect";
        }

        
        private void ReadString()
        {
            StringBuilder sb = new StringBuilder();
            int[] lpData = new int[10];

            int a = plc.ReadDeviceBlock("D100", lpData.Length, out lpData[0]);

            foreach (short item in lpData)
            {
                string s = ChuyenDoiWordSangString(item);
                sb.Append(s);
            }

            textBox1.Text = sb.ToString();  
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
           ReadString();
        }




        static string ChuyenDoiWordSangString(short so)
        {
            string ketQua = ((char)(so & 0xFF)).ToString() + ((char)((so >> 8) & 0xFF)).ToString();
            return ketQua;
        }



        


        private async void Test()
        {
            Task<int> task = LongRunning();
            int result = await task;
            Task task1 = Task.Factory.StartNew(() => DoWork(1));
            Task task2 = Task.Factory.StartNew(() => DoWork(2));
            Task task3 = Task.Factory.StartNew(() => DoWork(3));

            Parallel.For(1, 20, RunTask);

            thread.Start();
            thread.Join();  
        }

        private void DoWork(int v)
        {
            throw new NotImplementedException();
        }

        public static void RunTask(int i)
        {
            PintInfo($"Start {i,3}");
            Task.Delay(1000).Wait();          // Task dừng 1s - rồi mới chạy tiếp
            PintInfo($"Finish {i,3}");
        }
        public static void PintInfo(string info) =>
            Console.WriteLine($"{info,10}    task:{Task.CurrentId,3}    " +
                              $"thread: {Thread.CurrentThread.ManagedThreadId}");


        private Thread thread = null;   
        public static async Task<int> LongRunning()
        {
            

            await Task.Delay(1000);
            return 42;
        }
       


    }
}
