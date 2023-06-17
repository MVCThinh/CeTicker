using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.PLC
{
    public class PLCHandle
    {

        // 16961 --> AB
        public static string ConvertWordToString(short num)
        {
            string ketQua = ((char)(num & 0xFF)).ToString() + ((char)((num >> 8) & 0xFF)).ToString();
            return ketQua;
        }
    }
}
