
using Bending.Data.Helpers;
using Bending.Data.Models;
using Bending.Data.Models.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static rs2DAlign.cs2DAlign;
using static System.Collections.Specialized.BitVector32;

namespace Bending.UC
{
    public partial class ucSetting : UserControl
    {



        public ucSetting()
        {
            InitializeComponent();

            Initial();
        }

        private void Initial()
        {
            PullFolder();
            PushView();
        }

        private void btnConfigSave_Click(object sender, EventArgs e)
        {
            PullView();
            PushFolder();
        }



        #region Đọc ghi dữ liệu từ Folder vào Setting

        string PathRoot = @"C:\EQData1\Config\";
        string ConfigName = "VisionConfig.ini";

        // Lấy giá trị từ Folder
        public void PullFolder()
        {
            try
            {
                string Section = "VISION";

                VisionSetting.SerialLoading1 = RWFile.ReadFile(Section, "SerialLoading1", "0");
                VisionSetting.SerialLoading2 = RWFile.ReadFile(Section, "SerialLoading2", "0");
                VisionSetting.SerialLaser1 = RWFile.ReadFile(Section, "SerialLaser1", "0");
                VisionSetting.SerialLaser2 = RWFile.ReadFile(Section, "SerialLaser2", "0");

            }
            catch (Exception)
            {
                throw;
            }
        }

        // Đẩy giá trị vào View
        public void PushView()
        {
            txtSerialLoading1.Text = VisionSetting.SerialLoading1;
            txtSerialLoading2.Text = VisionSetting.SerialLoading2;
            txtSerialLaser1.Text = VisionSetting.SerialLaser1;
            txtSerialLaser2.Text = VisionSetting.SerialLaser2;

        }


        // Lấy giá trị từ View
        public void PullView()
        {
            VisionSetting.SerialLoading1 = txtSerialLoading1.Text;
            VisionSetting.SerialLoading2 = txtSerialLoading2.Text;
            VisionSetting.SerialLaser1 = txtSerialLaser1.Text;
            VisionSetting.SerialLaser2 = txtSerialLaser2.Text;

        }

        // Đẩy giá trị vào Folder
        public void PushFolder()
        {
            try
            {
                string Section = "VISION";

                RWFile.WriteFile(Section, "SerialLoading1", VisionSetting.SerialLoading1);
                RWFile.WriteFile(Section, "SerialLoading1", VisionSetting.SerialLoading2);
                RWFile.WriteFile(Section, "SerialLoading1", VisionSetting.SerialLaser1);
                RWFile.WriteFile(Section, "SerialLoading1", VisionSetting.SerialLaser2);

            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion


    }

}

