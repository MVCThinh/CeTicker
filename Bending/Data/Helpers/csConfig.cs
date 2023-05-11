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

        private readonly CamSettingModel _camSetting;
        private readonly LaserModel _laser;
        private readonly OffsetModel _offset;

        public csConfig(CamSettingModel camSetting, LaserModel laser, OffsetModel offset)
        {
            _camSetting = camSetting;
            _laser = laser;
            _offset = offset;
        }

        public bool ReadParameterToFolder()
        {
            RWFile.RWFilePath = @"C:\EQData1\Config\VisionConfig.ini";
            
            try
            {
                string Section = "CAMSETTING";
                _camSetting.FOVX = RWFile.ReadFile(Section, "FOVX", "0");
                _camSetting.FOVY = RWFile.ReadFile(Section, "FOVY", "0");
                _camSetting.Resolution = RWFile.ReadFile(Section, "Resolution", "0");
                _camSetting.Serial = RWFile.ReadFile(Section, "Serial", "0");
                _camSetting.PatternSearchMode = RWFile.ReadFile(Section, "PatternSearchMode", "0");
                _camSetting.PatternSearchTool = RWFile.ReadFile(Section, "PatternSearchTool", "0");
                _camSetting.CalType = RWFile.ReadFile(Section, "CalType", "0");
                _camSetting.LightType = RWFile.ReadFile(Section, "LightType", "0");
                _camSetting.LighComport = RWFile.ReadFile(Section, "LighComport", "0");
                _camSetting.LightChanel = RWFile.ReadFile(Section, "LightChanel", "0");
                _camSetting.CameraReverse = RWFile.ReadFile(Section, "CameraReverse", "0");
                _camSetting.ImageSaveType = RWFile.ReadFile(Section, "ImageSaveType", "0");
                _camSetting.GrapDelay = RWFile.ReadFile(Section, "GrapDelay", "0");
                _camSetting.LightDelay = RWFile.ReadFile(Section, "LightDelay", "0");
                _camSetting.AlignLimitX = RWFile.ReadFile(Section, "AlignLimitX", "0");
                _camSetting.AlignLimitY = RWFile.ReadFile(Section, "AlignLimitY", "0");
                _camSetting.AlignLimitT = RWFile.ReadFile(Section, "AlignLimitT", "0");
                _camSetting.RetryLimitCount = RWFile.ReadFile(Section, "RetryLimitCount", "0");
                _camSetting.RetryCaptureCount = RWFile.ReadFile(Section, "RetryCaptureCount", "0");
                _camSetting.ImageAutoDeleteDay = RWFile.ReadFile(Section, "ImageAutoDeleteDay", "0");
                _camSetting.CenterAlign = RWFile.ReadFile(Section, "CenterAlign", "0");




                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
