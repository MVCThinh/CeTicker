using ActUtlTypeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bending.Foam
{
    public partial class PLC : Form
    {

        private ActUtlType plc = new ActUtlType();
        public PLC()
        {
            InitializeComponent();

            plc.ActLogicalStationNumber = 0;
        }

        private bool Connection()
        {
            return (plc.Open() == 0 && plc.Connect() == 0);
        }
        private void PLC_Load(object sender, EventArgs e)
        {
            txtbStatus.Text = Connection() ? "Connected" : "DisConnected";

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Khai báo một mảng để lưu trữ dữ liệu đọc được
            int[] data = new int[10];

            // Đọc khối dữ liệu từ địa chỉ D100 đến D109
            plc.ReadDeviceBlock("D200", 10, out data[0]);

            // Hiển thị các giá trị đọc được
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Giá trị tại ô nhớ D{0}: {1}", 200 + i, data[i]);
            }



            byte[] bytes = BitConverter.GetBytes(data[0]);
            txtbD100.Text = Encoding.ASCII.GetString(bytes);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string inputString = "HE,0,100.2,60,-30";

            // Chuyển đổi chuỗi thành dữ liệu số hoặc dạng ASCII tương ứng
            int intValue = 0;
            float floatValue = 0;
            bool success = int.TryParse(inputString.Split(',')[1], out intValue);
            success = float.TryParse(inputString.Split(',')[2], out floatValue);

            // Gán giá trị vào thanh ghi D100 trong PLC
           // plc.WriteDeviceBlock("D100", new object[] { intValue, floatValue });
        }

        public int MaxScore(int[] cardPoints, int k)
        {
            if (k == cardPoints.Length)
            {
                return cardPoints.Sum();
            }

            int[] left = new int[k];
            int[] right = new int[k];

            for (int i = 0; i < k; i++)
            {
                left[i] = cardPoints[i];
                right[i] = cardPoints[cardPoints.Length - 1 - i];
            }

            int[] addcards = left.Concat(right).ToArray();
            Array.Sort(addcards);

            int result = 0;
            for (int i = 0; i < k; i++)
            {
                result += addcards[addcards.Length - 1 - i];
            }
            return result;



           
        }
    }
}
