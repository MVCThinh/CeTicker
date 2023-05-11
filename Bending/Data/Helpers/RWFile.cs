using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Helpers
{
    public static class RWFile
    {
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string strSection, string strKey, string strValue, string strFilePath);

        public static string RWFilePath { get; set; }
        public static string ReadFile(string Section, string Key, string Value = "")
        {
            try
            {
                StringBuilder sb = new StringBuilder(500);
                int Flag = GetPrivateProfileString(Section, Key, Value, sb, 500, RWFilePath);

                return sb.ToString();
            }
            catch (Exception)
            {
                return Value;
            }
        }

        public static string WriteFile(string Section, string Key, string Value)
        {
            try
            {
                WritePrivateProfileString(Section, Key, Value, RWFilePath);
                return "Successful";
            }
            catch (Exception)
            {
                return "Fail";
            }
        }
    }
}
