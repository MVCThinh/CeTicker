using Bending.Data.Enums;
using Bending.Data.Helpers;
using Bending.Data.Models;
using Bending.Data.Static;
using System;
using System.Collections.Generic;
using System.IO;
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

        private readonly Parameter _paramConfig;
        private readonly PLC _plcConfig;
        private readonly PC _pcConfig;
        private readonly FolderPath _folderPathConfig;

        
        


        private string cINIPath = null;
       // private string cRecipeName = null;

        public csConfig( Parameter paramConfig, PLC plcConfig, PC pcConfig, FolderPath folderPathConfig)
        {
            _paramConfig = paramConfig;
            _plcConfig = plcConfig;
            _pcConfig = pcConfig;
            _folderPathConfig = folderPathConfig;
        }

        private string INIFileRead(string Section, string Key, string sdefault = "")
        {
            try
            {
                StringBuilder sb = new StringBuilder(500);
                int Flag = GetPrivateProfileString(Section, Key, sdefault, sb, 500, cINIPath);

                return sb.ToString();
            }
            catch (Exception)
            {
                return sdefault;
            }
        }








        public bool Initial()
        {
            try
            {


                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
