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


        private void ParamConfig()
        {
            _paramConfig.EQPID = INIFileRead("Config", "EQPID");
            _paramConfig.PCName = INIFileRead("Config", "PCNAME");
            _paramConfig.UnitNo = INIFileRead("Config", "UNITNO");
            _paramConfig.PCNo = int.Parse(INIFileRead("Config", "PCNO"));
            _paramConfig.Folder = INIFileRead("Config", "FOLDER", "C");
            _paramConfig.Folder2 = INIFileRead("Config", "FOLDER2", "D");
            _paramConfig.CAMCnt = int.Parse(INIFileRead("Config", "CAMCOUNT"));
            _paramConfig.PLCType = int.Parse(INIFileRead("Config", "PLCTYPE"));
            _paramConfig.PLCIP = INIFileRead("Config", "PLCIP");
            _paramConfig.StationNO = int.Parse(INIFileRead("Config", "STATIONNO"));
            _paramConfig.PLCDeviceType = INIFileRead("Config", "PLCDEVICE");
            _paramConfig.HeightIP = INIFileRead("Config", "HEIGHTIP");
            _paramConfig.RESULT_TITLE1 = INIFileRead("Config", "RESULT_TITLE1");
            _paramConfig.RESULT_TITLE2 = INIFileRead("Config", "RESULT_TITLE2");
            _paramConfig.RESULT_TITLE3 = INIFileRead("Config", "RESULT_TITLE3");
            _paramConfig.RESULT_TITLE4 = INIFileRead("Config", "RESULT_TITLE4");

            _paramConfig.RESULT1_TYPE = INIFileRead("Config", "RESULT1_TYPE");
            _paramConfig.RESULT2_TYPE = INIFileRead("Config", "RESULT2_TYPE");
            _paramConfig.RESULT3_TYPE = INIFileRead("Config", "RESULT3_TYPE");
            _paramConfig.RESULT4_TYPE = INIFileRead("Config", "RESULT4_TYPE");
            _paramConfig.RESULT5_TYPE = INIFileRead("Config", "RESULT5_TYPE");

        }

        private void AddressConfig()
        {
            

            _plcConfig.BITCONTROL = int.Parse(INIFileRead("Address_", "PLCBITCONTROL"));

            _plcConfig.REPLY = int.Parse(INIFileRead("Address_", "PLCREPLY"));
            _plcConfig.MODE = int.Parse(INIFileRead("Address_", "PLCMODE"));
            _plcConfig.CURRENTPOSITION = int.Parse(INIFileRead("Address_", "PLCCURRENTPOSITION"));
            _plcConfig.CHANGETIME = int.Parse(INIFileRead("Address_", "PLCCHANGETIME"));
            _plcConfig.CELLID1 = int.Parse(INIFileRead("Address_", "PLCCELLID1"));
            _plcConfig.CELLID2 = int.Parse(INIFileRead("Address_", "PLCCELLID2"));
            _plcConfig.CELLID3 = int.Parse(INIFileRead("Address_", "PLCCELLID3"));
            _plcConfig.CELLID4 = int.Parse(INIFileRead("Address_", "PLCCELLID4"));
            //20.10.16 lkw
            _plcConfig.CELLID5 = int.Parse(INIFileRead("Address_", "PLCCELLID5"));
            _plcConfig.CELLID6 = int.Parse(INIFileRead("Address_", "PLCCELLID6"));
            _plcConfig.CELLID7 = int.Parse(INIFileRead("Address_", "PLCCELLID7"));
            _plcConfig.CELLID8 = int.Parse(INIFileRead("Address_", "PLCCELLID8"));
            _plcConfig.RECIPEID = int.Parse(INIFileRead("Address_", "PLCRECIPEID"));
            _plcConfig.RECIPEPARAM = int.Parse(INIFileRead("Address_", "PLCRECIPEPARAM"));
            _plcConfig.POSITION = int.Parse(INIFileRead("Address_", "PLCPOSITION"));
            _plcConfig.PLC_CAL_MOVE = int.Parse(INIFileRead("Address_", "PLCCALMOVE"));
            _plcConfig.INSPECTIONBENDINGLAST = int.Parse(INIFileRead("Address_", "PLCINSPECTIONBENDINGLAST", "10350"));
            //210118 cjm 레이저 로그
            _plcConfig.LaserSendCellID = int.Parse(INIFileRead("Address_", "PLCLaserSendCellID", "10900"));
            _plcConfig.MCRCellID = int.Parse(INIFileRead("Address_", "PLCMCRCellID", "11000"));

            //PC
            _pcConfig.BITCONTROL = int.Parse(INIFileRead("Address_", "PCBITCONTROL"));

            _pcConfig.CALIBRATION = int.Parse(INIFileRead("Address_", "PCCALIBRATION"));
            _pcConfig.REPLY = int.Parse(INIFileRead("Address_", "PCREPLY"));
            _pcConfig.VISIONOFFSET = int.Parse(INIFileRead("Address_", "PCVISIONOFFSET"));

            //벤딩궤적주소
            _pcConfig.BENDING1 = int.Parse(INIFileRead("Address_", "PCBENDING1"));
            _pcConfig.BENDING2 = int.Parse(INIFileRead("Address_", "PCBENDING2"));
            _pcConfig.BENDING3 = int.Parse(INIFileRead("Address_", "PCBENDING3"));
            _pcConfig.SV = int.Parse(INIFileRead("Address_", "PCSV"));
            _pcConfig.DV = int.Parse(INIFileRead("Address_", "PCDV"));
            _pcConfig.PC_CAL_MOVE = int.Parse(INIFileRead("Address_", "PCCALMOVE"));
            _pcConfig.CPK = int.Parse(INIFileRead("Address_", "PCCPK"));

            _pcConfig.MatchingScore = int.Parse(INIFileRead("Address_", "PCMATCHINGSCORE"));


            _pcConfig.APNCode1 = int.Parse(INIFileRead("Address_", "PCAPNCODE1"));
            _pcConfig.APNCode2 = int.Parse(INIFileRead("Address_", "PCAPNCODE2"));



            //SetOffsetAddress(_pcConfig.VISIONOFFSET);
            //SetMotionAddress(_plcConfig.POSITION);
            ////pcy210119
            //SetDVAddress(_pcConfig.DV);
            //SetSVAddress(_pcConfig.SV);
            //SetMatchingScoreAddress(_pcConfig.MatchingScore);
        }

        private void FolderPathConfig()
        {
            _folderPathConfig.cSideVisionPath = Path.Combine(_paramConfig.Folder2, _folderPathConfig.cSideVisionPath);
            _folderPathConfig.cImagePath = Path.Combine(_paramConfig.Folder2, _folderPathConfig.cImagePath);
            _folderPathConfig.cVisionPath = Path.Combine(_paramConfig.Folder, _folderPathConfig.cVisionPath); //_folderPathConfig.Folder + _folderPathConfig.cVisionImgPath;  //D Driver
            _folderPathConfig.cRecipeSavePath = Path.Combine(_paramConfig.Folder, _folderPathConfig.cRecipeSavePath);
            _folderPathConfig.cTracePath = Path.Combine(_paramConfig.Folder, _folderPathConfig.cTracePath);
            _folderPathConfig.cMotionTracePath = Path.Combine(_paramConfig.Folder, _folderPathConfig.cMotionTracePath);
            _folderPathConfig.cConfigSavePath = Path.Combine(_paramConfig.Folder, _folderPathConfig.cConfigSavePath); // lyw420. 20170107 추가.
            _folderPathConfig.cDefaultDataPath = Path.Combine(_paramConfig.Folder, _folderPathConfig.cDefaultDataPath); // lyw. default config.

            _folderPathConfig.cLogPath = Path.Combine(_paramConfig.Folder2, @"EQData\Log\");
            _folderPathConfig.cExceptionLogPath = Path.Combine(_paramConfig.Folder2, _paramConfig.PCName, "ExceptionLog"); //고객사 생산장비 보안 체크리스트에 맞게 작성
            _folderPathConfig.cSystemLogPath = Path.Combine(_paramConfig.Folder2, @"EQData\Log\SystemLog");
            _folderPathConfig.cInspectionLogPath = Path.Combine(_paramConfig.Folder2, @"EQData\Log\InspectionLog");
        }

        public bool Initial()
        {
            try
            {
                ParamConfig();
                AddressConfig();
                FolderPathConfig();


                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
