using Bending.Data.Enums;
using Bending.Data.Helpers;
using Bending.Data.Models;
using Bending.Data.Static;
using Bending.UC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bending.Data.Class
{
    public class csConfig
    {
        private readonly CamSettingModel _camSetting;
        private readonly  LaserModel _laser; 
        private readonly  OffsetModel _offset;

        public csConfig()
        {

        }

        public csConfig(CamSettingModel camSetting, LaserModel laser, OffsetModel offset)
        {
            _camSetting = camSetting;
            _laser = laser;
            _offset = offset;
        }







    }
}
