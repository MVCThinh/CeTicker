using Bending.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Class
{
    public class csConfig
    {
        #region DLL - Đọc_Ghi dữ liệu
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string strSection, string strKey, string strValue, string strFilePath);

        #endregion

        // Đường dẫn

        private readonly csLog _csLog;

        


        private string cINIPath = null;
        private string cRecipeName = null;

        public csConfig(csLog csLog)
        {
            _csLog = csLog;
        }

        private string INIFileRead(string Section, string Key, string sdefault = "")
        {
            try
            {
                StringBuilder sb = new StringBuilder(500);
                int Flag = GetPrivateProfileString(Section, Key, sdefault, sb, 500, cINIPath);

                return sb.ToString();
            }
            catch (Exception ex)
            {
                _csLog.ExceptionLogSave("INIFileRead" + ", " + ex.GetType().Name + ", " + ex.Message);
                return sdefault;
            }
        }

    }
}
