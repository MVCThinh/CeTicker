using Bending.Data.Helpers;
using Bending.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bending.Data.Models.CamSetting;

namespace Bending.UC
{
    public partial class ucSetting : UserControl
    {
        private readonly CamSetting _camSetting;
        private CamSetting cam1 = new CamSetting();
        public ucSetting(CamSetting camSetting)
        {
            InitializeComponent();

            _camSetting = camSetting;


            InitialConfig();
        }

        private void InitialConfig()
        {
            RWFile.RWFilePath = @"C:\EQData1\Config\VisionConfig.ini";

            string Section = "CAMSETTING";

            _camSetting.FOVX = RWFile.ReadFile(Section, "FOVX", "0");
            _camSetting.FOVY = RWFile.ReadFile(Section, "FOVY", "0");
            _camSetting.Resolution = RWFile.ReadFile(Section, "Resolution", "0");
            _camSetting.Serial = RWFile.ReadFile(Section, "Serial", "0");
            


            //RWFile.ReadFile()
            // Đọc file trong vision config.
        }
    }
}
