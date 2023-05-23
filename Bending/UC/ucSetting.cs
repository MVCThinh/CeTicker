
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
        public static CamSetting Laser1 = new CamSetting();
        public static CamSetting Laser2 = new CamSetting();
        public static CamSetting LoadingPre1 = new CamSetting();
        public static CamSetting LoadingPre2 = new CamSetting();

        public static CamSetting[] AllCamSetting = { Laser1, Laser2, LoadingPre1,LoadingPre2 };

        public ucSetting()
        {
            InitializeComponent();

            Initial();
        }

        private void Initial()
        {
            cboName.DataSource = Enum.GetValues(typeof(eCamName));
            ReadParaFormFolder();
            ReadParaModelToView();
        }

        private void btnConfigSave_Click(object sender, EventArgs e)
        {
            WriteParaViewToModel();
            WriteParaToFolder();
        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            eCamName camName = (eCamName)cboName.SelectedItem;
            CamSetting camSetting = GetCamSettingByName(camName);

            if (camSetting != null)
            {
                PushParaViewToModel(camSetting);

            }
        }

        private void PushParaViewToModel (CamSetting camSetting)
        {
            txtSerial.Text = camSetting.Serial;

            cbLightType.SelectedIndex = camSetting.LightType;
            txtLight1Comport.Text = camSetting.LighComport;
            txtLight1CH.Text = camSetting.LightChanel;


            cbImageSaveType.SelectedIndex = camSetting.ImageSaveType;

            txtGrabDelay.Text = camSetting.GrapDelay;
            txtLightDelay.Text = camSetting.LightDelay;


            txtAlignLimitCnt.Text = camSetting.RetryLimitCount;
            txtRetryCnt.Text = camSetting.RetryCaptureCount;
            txtImgAutoDelDay.Text = camSetting.ImageAutoDeleteDay;
        }

        private void PushParaModelToView(CamSetting camSetting)
        {
                camSetting.Serial = txtSerial.Text;

                camSetting.LightType = cbLightType.SelectedIndex;
                camSetting.LighComport = txtLight1Comport.Text;
                camSetting.LightChanel = txtLight1CH.Text;

                camSetting.ImageSaveType = cbImageSaveType.SelectedIndex;

                camSetting.GrapDelay = txtGrabDelay.Text;
                camSetting.LightDelay = txtLightDelay.Text;


                camSetting.RetryLimitCount = txtAlignLimitCnt.Text;
                camSetting.RetryCaptureCount = txtRetryCnt.Text;
                camSetting.ImageAutoDeleteDay = txtImgAutoDelDay.Text;
            }




        #region Đọc ghi dữ liệu từ Folder vào Setting

        string PathRoot = @"C:\EQData1\Config\";
        string ConfigName = "VisionConfig.ini";


        /// <summary>
        /// Viết giá trị từ View vào Model
        /// </summary>
        public void WriteParaViewToModel()
        {
            eCamName camName = (eCamName)cboName.SelectedItem;
            CamSetting camSetting = GetCamSettingByName(camName);

            if (camSetting != null)
            {
                PushParaModelToView(camSetting);

            }         
        }

        /// <summary>
        /// Đẩy giá trị từ Model tới View
        /// </summary>
        public void ReadParaModelToView()
        {
            eCamName camName = (eCamName)cboName.SelectedItem;
            CamSetting camSetting = GetCamSettingByName(camName);

            if (camSetting != null)
            {
                txtSerial.Text = camSetting.Serial;

                cbLightType.SelectedIndex = camSetting.LightType;
                txtLight1Comport.Text = camSetting.LighComport;
                txtLight1CH.Text = camSetting.LightChanel;


                cbImageSaveType.SelectedIndex = camSetting.ImageSaveType;

                txtGrabDelay.Text = camSetting.GrapDelay;
                txtLightDelay.Text = camSetting.LightDelay;


                txtAlignLimitCnt.Text = camSetting.RetryLimitCount;
                txtRetryCnt.Text = camSetting.RetryCaptureCount;
                txtImgAutoDelDay.Text = camSetting.ImageAutoDeleteDay;

            }
        }

        void ReadCamSetting(ref CamSetting camSetting)
        {
            string Section = "CAMSETTING";

            camSetting.Serial = RWFile.ReadFile(Section, "Serial", "0");

            camSetting.LightType = int.Parse(RWFile.ReadFile(Section, "LightType", "0"));
            camSetting.LighComport = RWFile.ReadFile(Section, "LighComport", "0");
            camSetting.LightChanel = RWFile.ReadFile(Section, "LightChanel", "0");

            camSetting.ImageSaveType = int.Parse(RWFile.ReadFile(Section, "ImageSaveType", "0"));

            camSetting.GrapDelay = RWFile.ReadFile(Section, "GrapDelay", "0");
            camSetting.LightDelay = RWFile.ReadFile(Section, "LightDelay", "0");

            camSetting.RetryLimitCount = RWFile.ReadFile(Section, "RetryLimitCount", "0");
            camSetting.RetryCaptureCount = RWFile.ReadFile(Section, "RetryCaptureCount", "0");
            camSetting.ImageAutoDeleteDay = RWFile.ReadFile(Section, "ImageAutoDeleteDay", "0");

        }
        void WriteCamSetting(ref CamSetting camSetting)
        {
            string Section = "CAMSETTING";
            RWFile.WriteFile(Section, "Serial", camSetting.Serial);



            RWFile.WriteFile(Section, "LightType", camSetting.LightType.ToString());
            RWFile.WriteFile(Section, "LighComport", camSetting.LighComport);
            RWFile.WriteFile(Section, "LightChanel", camSetting.LightChanel);


            RWFile.WriteFile(Section, "ImageSaveType", camSetting.ImageSaveType.ToString());
            RWFile.WriteFile(Section, "GrapDelay", camSetting.GrapDelay);
            RWFile.WriteFile(Section, "LightDelay", camSetting.LightDelay);


            RWFile.WriteFile(Section, "RetryLimitCount", camSetting.RetryLimitCount);
            RWFile.WriteFile(Section, "RetryCaptureCount", camSetting.RetryCaptureCount);
            RWFile.WriteFile(Section, "ImageAutoDeleteDay", camSetting.ImageAutoDeleteDay);
        }

        /// <summary>
        /// Đẩy giá trị từ Folder vào Model
        /// </summary>
        /// <returns></returns>
        public void ReadParaFormFolder()
        {
            try
            {
                string[] camNames = Enum.GetNames(typeof(eCamName));

                foreach (string camName in camNames)
                {
                    if (Enum.TryParse(camName, out eCamName parsedCamName))
                    {
                        CamSetting camSetting = GetCamSettingByName(parsedCamName);
                        if (camSetting != null)
                        {
                            RWFile.RWFilePath = Path.Combine(PathRoot, camName, ConfigName);
                            ReadCamSetting(ref camSetting);
                        }
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Viết giá trị từ Model vào Folder
        /// </summary>
        public void WriteParaToFolder()
        {
            try
            {
                string[] camNames = Enum.GetNames(typeof(eCamName));

                foreach (string camName in camNames)
                {
                    if (Enum.TryParse(camName, out eCamName parsedCamName))
                    {
                        CamSetting camSetting = GetCamSettingByName(parsedCamName);
                        if (camSetting != null)
                        {
                            RWFile.RWFilePath = Path.Combine(PathRoot, camName, ConfigName);
                            WriteCamSetting(ref camSetting);
                        }
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private CamSetting GetCamSettingByName(eCamName camName)
        {
            switch (camName)
            {
                case eCamName.LoadingPre1:
                    return LoadingPre1;
                case eCamName.LoadingPre2:
                    return LoadingPre2;
                case eCamName.Laser1:
                    return Laser1;
                case eCamName.Laser2:
                    return Laser2;
                default:
                    return null;
            }
        }

        #endregion


    }

}

