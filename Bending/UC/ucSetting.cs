using Bending.Data.Class;
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

        public ucSetting()
        {
            InitializeComponent();

            Initial();
        }

        private void Initial()
        {
            cboName.DataSource = Enum.GetValues(typeof(eCamName));
            ReadParameterFormFolder();
            ReadParameterModelToView();
        }

        private void btnConfigSave_Click(object sender, EventArgs e)
        {
            WriteParameterViewToModel();
            WriteParameterToFolder();
        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadParameterModelToView();
        }




        #region Đọc ghi dữ liệu từ Folder vào Setting

        string PathRoot = @"C:\EQData1\Config\";
        string ConfigName = "VisionConfig.ini";


        void WriteCamSettingViewToModel(CamSetting camSetting)
        {
            camSetting.FOVX = txtFovX.Text;
            camSetting.FOVY = txtFovY.Text;

            camSetting.Resolution = txtResolution.Text;
            camSetting.Serial = txtSerial.Text;

            camSetting.PatternSearchMode = cbPatternSearchMode.SelectedIndex;
            camSetting.PatternSearchTool = cbPatternSearchTool.SelectedIndex;

            camSetting.LightType = cbLightType.SelectedIndex;
            camSetting.LighComport = txtLight1Comport.Text;
            camSetting.LightChanel = txtLight1CH.Text;

            camSetting.CameraReverse = cbReverseMode.SelectedIndex;
            camSetting.ImageSaveType = cbImageSaveType.SelectedIndex;

            camSetting.GrapDelay = txtGrabDelay.Text;
            camSetting.LightDelay = txtLightDelay.Text;

            camSetting.AlignLimitX = txtAlignLimitX.Text;
            camSetting.AlignLimitY = txtAlignLimitY.Text;
            camSetting.AlignLimitT = txtAlignLimitT.Text;

            camSetting.RetryLimitCount = txtAlignLimitCnt.Text;
            camSetting.RetryCaptureCount = txtRetryCnt.Text;
            camSetting.ImageAutoDeleteDay = txtImgAutoDelDay.Text;

            camSetting.CenterAlign = Convert.ToInt32(cbCenterAlign.Checked);
        }

        void WriteCamOffsetViewToModel(CamSetting camSetting)
        {
            camSetting.AlignOffsetX = txtAlignXOffset1.Text;
            camSetting.AlignOffsetY = txtAlignYOffset1.Text;
            camSetting.AlignOffsetT = txtAlignTOffset1.Text;

            camSetting.CalOffsetX = txtCalXOffset.Text;
            camSetting.CalOffsetY = txtCalYOffset.Text;
            camSetting.CalOffsetT = txtCalTOffset.Text;

            camSetting.LengthOffset1 = txtLengthOffset1.Text;
            camSetting.LengthOffset2 = txtLengthOffset2.Text;
        }

        void WriteCamLaserViewToModel(CamSetting camSetting)
        {
            camSetting.MarkPositionTolX = txtMarkPosTorX.Text;
            camSetting.MarkPositionTolY = txtMarkPosTorY.Text;
            camSetting.MaxSizeX = txtMarkSizeX.Text;
            camSetting.MaxSizeY = txtMarkSizeY.Text;

            camSetting.AlignRefSearch = cbRefsearch.SelectedIndex;
            camSetting.UseImageProcessing = Convert.ToInt32(cbImageProcessing.Checked);

            camSetting.BlobSearchMaxPos = cbMassPosition.SelectedIndex;
            camSetting.BlobBoxUsePoint = cbBlobBox.SelectedIndex;
            camSetting.BlobPolarity = cbPolarity.SelectedIndex;
            camSetting.ConnectivityMinPixels = txtMinPixel.Text;

            camSetting.MCRSearch = cbMCRSearch.SelectedIndex;
            camSetting.MCRRight = Convert.ToInt32(cbMCRRight.Checked);
            camSetting.MCRUp = Convert.ToInt32(cbMCRUp.Checked);

            camSetting.InspectDegreeKind = cbInspKind.SelectedIndex;
            camSetting.LaserAlignRefPosTol = txtLaserAlignTor.Text;
        }

        /// <summary>
        /// Viết giá trị từ View vào Model
        /// </summary>
        public void WriteParameterViewToModel()
        {
            eCamName camName = (eCamName)cboName.SelectedItem;
            CamSetting cam = GetCamSettingByCamName(camName);

            if (cam != null)
            {
                WriteCamSettingViewToModel(cam);
                WriteCamOffsetViewToModel(cam);
                WriteCamLaserViewToModel(cam);
            }
        }

        void ReadCamSettingModelToView( CamSetting camSetting)
        {
            txtFovX.Text = camSetting.FOVX;
            txtFovY.Text = camSetting.FOVY;

            txtResolution.Text = camSetting.Resolution;
            txtSerial.Text = camSetting.Serial;

            cbPatternSearchMode.SelectedIndex = camSetting.PatternSearchMode;
            cbPatternSearchTool.SelectedIndex = camSetting.PatternSearchTool;

            cbLightType.SelectedIndex = camSetting.LightType;
            txtLight1Comport.Text = camSetting.LighComport;
            txtLight1CH.Text = camSetting.LightChanel;

            cbReverseMode.SelectedIndex = camSetting.CameraReverse;
            cbImageSaveType.SelectedIndex = camSetting.ImageSaveType;

            txtGrabDelay.Text = camSetting.GrapDelay;
            txtLightDelay.Text = camSetting.LightDelay;

            txtAlignLimitX.Text = camSetting.AlignLimitX;
            txtAlignLimitY.Text = camSetting.AlignLimitY;
            txtAlignLimitT.Text = camSetting.AlignLimitT;

            txtAlignLimitCnt.Text = camSetting.RetryLimitCount;
            txtRetryCnt.Text = camSetting.RetryCaptureCount;
            txtImgAutoDelDay.Text = camSetting.ImageAutoDeleteDay;

            cbCenterAlign.Checked = Convert.ToBoolean(camSetting.CenterAlign);
        }

        void ReadCamOffsetModelToView (CamSetting camSetting)
        {
            txtAlignXOffset1.Text = camSetting.AlignOffsetX;
            txtAlignYOffset1.Text = camSetting.AlignOffsetY;
            txtAlignTOffset1.Text = camSetting.AlignOffsetT;

            txtCalXOffset.Text = camSetting.CalOffsetX;
            txtCalYOffset.Text = camSetting.CalOffsetY;
            txtCalTOffset.Text = camSetting.CalOffsetT;

            txtLengthOffset1.Text = camSetting.LengthOffset1;
            txtLengthOffset2.Text = camSetting.LengthOffset2;
        }

        void ReadCamLaserModelToView(CamSetting camSetting)
        {
            txtMarkPosTorX.Text = camSetting.MarkPositionTolX;
            txtMarkPosTorY.Text = camSetting.MarkPositionTolY;
            txtMarkSizeX.Text = camSetting.MaxSizeX;
            txtMarkSizeY.Text = camSetting.MaxSizeY;

            cbRefsearch.SelectedIndex = camSetting.AlignRefSearch;
            cbImageProcessing.Checked = Convert.ToBoolean(camSetting.UseImageProcessing);

            cbMassPosition.SelectedIndex = camSetting.BlobSearchMaxPos;
            cbBlobBox.SelectedIndex = camSetting.BlobBoxUsePoint;
            cbPolarity.SelectedIndex = camSetting.BlobPolarity;
            txtMinPixel.Text = camSetting.ConnectivityMinPixels;

            cbMCRSearch.SelectedIndex = camSetting.MCRSearch;
            cbMCRRight.Checked = Convert.ToBoolean(camSetting.MCRRight);
            cbMCRUp.Checked = Convert.ToBoolean(camSetting.MCRUp);

            cbInspKind.SelectedIndex = camSetting.InspectDegreeKind;
            txtLaserAlignTor.Text = camSetting.LaserAlignRefPosTol;
        }


        /// <summary>
        /// Đẩy giá trị từ Model tới View
        /// </summary>
        public void ReadParameterModelToView()
        {
            eCamName camName = (eCamName)cboName.SelectedItem;
            CamSetting cam = GetCamSettingByCamName(camName);

            if (cam != null)
            {
                ReadCamSettingModelToView(cam);
                ReadCamOffsetModelToView(cam);
                ReadCamLaserModelToView(cam);
            }
        }

        private CamSetting GetCamSettingByCamName(eCamName camName)
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


        void ReadCamSetting(ref CamSetting camSetting)
        {
            string Section = "CAMSETTING";

            camSetting.FOVX = RWFile.ReadFile(Section, "FOVX", "0");
            camSetting.FOVY = RWFile.ReadFile(Section, "FOVY", "0");
            camSetting.Resolution = RWFile.ReadFile(Section, "Resolution", "0");
            camSetting.Serial = RWFile.ReadFile(Section, "Serial", "0");

            camSetting.PatternSearchMode = int.Parse(RWFile.ReadFile(Section, "PatternSearchMode", "0"));
            camSetting.PatternSearchTool = int.Parse(RWFile.ReadFile(Section, "PatternSearchTool", "0"));

            camSetting.LightType = int.Parse(RWFile.ReadFile(Section, "LightType", "0"));
            camSetting.LighComport = RWFile.ReadFile(Section, "LighComport", "0");
            camSetting.LightChanel = RWFile.ReadFile(Section, "LightChanel", "0");

            camSetting.CameraReverse = int.Parse(RWFile.ReadFile(Section, "CameraReverse", "0"));
            camSetting.ImageSaveType = int.Parse(RWFile.ReadFile(Section, "ImageSaveType", "0"));

            camSetting.GrapDelay = RWFile.ReadFile(Section, "GrapDelay", "0");
            camSetting.LightDelay = RWFile.ReadFile(Section, "LightDelay", "0");

            camSetting.AlignLimitX = RWFile.ReadFile(Section, "AlignLimitX", "0");
            camSetting.AlignLimitY = RWFile.ReadFile(Section, "AlignLimitY", "0");
            camSetting.AlignLimitT = RWFile.ReadFile(Section, "AlignLimitT", "0");

            camSetting.RetryLimitCount = RWFile.ReadFile(Section, "RetryLimitCount", "0");
            camSetting.RetryCaptureCount = RWFile.ReadFile(Section, "RetryCaptureCount", "0");
            camSetting.ImageAutoDeleteDay = RWFile.ReadFile(Section, "ImageAutoDeleteDay", "0");

            camSetting.CenterAlign = int.Parse(RWFile.ReadFile(Section, "CenterAlign", "0"));

        }
        void ReadCamOffset(ref CamSetting camSetting)
        {
            string Section = "OFFSET";

            camSetting.AlignOffsetX = RWFile.ReadFile(Section, "AlignOffsetX", "0");
            camSetting.AlignOffsetY = RWFile.ReadFile(Section, "AlignOffsetY", "0");
            camSetting.AlignOffsetT = RWFile.ReadFile(Section, "AlignOffsetT", "0");

            camSetting.CalOffsetX = RWFile.ReadFile(Section, "CalOffsetX", "0");
            camSetting.CalOffsetY = RWFile.ReadFile(Section, "CalOffsetY", "0");
            camSetting.CalOffsetT = RWFile.ReadFile(Section, "CalOffsetT", "0");

            camSetting.LengthOffset1 = RWFile.ReadFile(Section, "LengthOffset1", "0");
            camSetting.LengthOffset2 = RWFile.ReadFile(Section, "LengthOffset2", "0");
        }
        void ReadCamLaser( ref CamSetting camSetting)
        {
            string Section = "LASER";

            camSetting.MarkPositionTolX = RWFile.ReadFile(Section, "MarkPositionTolX", "0");
            camSetting.MarkPositionTolY = RWFile.ReadFile(Section, "MarkPositionTolY", "0");

            camSetting.MaxSizeX = RWFile.ReadFile(Section, "MaxSizeX", "0");
            camSetting.MaxSizeY = RWFile.ReadFile(Section, "MaxSizeY", "0");
            camSetting.AlignRefSearch = int.Parse(RWFile.ReadFile(Section, "AlignRefSearch", "0"));
            camSetting.UseImageProcessing = int.Parse(RWFile.ReadFile(Section, "UseImageProcessing", "0"));

            camSetting.BlobSearchMaxPos = int.Parse(RWFile.ReadFile(Section, "BlobSearchMaxPos", "0"));
            camSetting.BlobBoxUsePoint = int.Parse(RWFile.ReadFile(Section, "BlobBoxUsePoint", "0"));
            camSetting.BlobPolarity = int.Parse(RWFile.ReadFile(Section, "BlobPolarity", "0"));
            camSetting.ConnectivityMinPixels = RWFile.ReadFile(Section, "ConnectivityMinPixels", "0");

            camSetting.MCRSearch = int.Parse(RWFile.ReadFile(Section, "MCRSearch", "0"));
            camSetting.MCRRight = int.Parse(RWFile.ReadFile(Section, "MCRRight", "0"));
            camSetting.MCRUp = int.Parse(RWFile.ReadFile(Section, "MCRUp", "0"));

            camSetting.InspectDegreeKind = int.Parse(RWFile.ReadFile(Section, "InspectDegreeKind", "0"));
            camSetting.LaserAlignRefPosTol = RWFile.ReadFile(Section, "LaserAlignRefPosTol", "0");
        }

        /// <summary>
        /// Đẩy giá trị từ Folder vào Model
        /// </summary>
        /// <returns></returns>
        public void ReadParameterFormFolder()
        {
            try
            {
                string[] camNames = Enum.GetNames(typeof(eCamName));

                foreach (string camName in camNames)
                {
                    RWFile.RWFilePath = Path.Combine(PathRoot, camName, ConfigName);

                    CamSetting camSetting;

                    switch (camName)
                    {
                        case "LoadingPre1":
                            camSetting = LoadingPre1;
                            break;
                        case "LoadingPre2":
                            camSetting = LoadingPre2;
                            break;
                        case "Laser1":
                            camSetting = Laser1;
                            break;
                        case "Laser2":
                            camSetting = Laser2;
                            break;
                        default:
                            continue;
                    }

                    ReadCamSetting(ref camSetting);
                    ReadCamOffset(ref camSetting);
                    ReadCamLaser(ref camSetting);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        void WriteCamSetting(ref CamSetting camSetting)
        {
            string Section = "CAMSETTING";

            RWFile.WriteFile(Section, "FOVX", camSetting.FOVX);
            RWFile.WriteFile(Section, "FOVY", camSetting.FOVY);

            RWFile.WriteFile(Section, "Resolution", camSetting.Resolution);
            RWFile.WriteFile(Section, "Serial", camSetting.Serial);

            RWFile.WriteFile(Section, "PatternSearchMode", camSetting.PatternSearchMode.ToString());
            RWFile.WriteFile(Section, "PatternSearchTool", camSetting.PatternSearchTool.ToString());

            RWFile.WriteFile(Section, "LightType", camSetting.LightType.ToString());
            RWFile.WriteFile(Section, "LighComport", camSetting.LighComport);
            RWFile.WriteFile(Section, "LightChanel", camSetting.LightChanel);

            RWFile.WriteFile(Section, "CameraReverse", camSetting.CameraReverse.ToString());
            RWFile.WriteFile(Section, "ImageSaveType", camSetting.ImageSaveType.ToString());
            RWFile.WriteFile(Section, "GrapDelay", camSetting.GrapDelay);
            RWFile.WriteFile(Section, "LightDelay", camSetting.LightDelay);

            RWFile.WriteFile(Section, "AlignLimitX", camSetting.AlignLimitX);
            RWFile.WriteFile(Section, "AlignLimitY", camSetting.AlignLimitY);
            RWFile.WriteFile(Section, "AlignLimitT", camSetting.AlignLimitT);

            RWFile.WriteFile(Section, "RetryLimitCount", camSetting.RetryLimitCount);
            RWFile.WriteFile(Section, "RetryCaptureCount", camSetting.RetryCaptureCount);
            RWFile.WriteFile(Section, "ImageAutoDeleteDay", camSetting.ImageAutoDeleteDay);

            RWFile.WriteFile(Section, "CenterAlign", camSetting.CenterAlign.ToString());
        }

        void WriteCamOffset(ref CamSetting camSetting)
        {
            string Section = "OFFSET";

            RWFile.WriteFile(Section, "AlignOffsetX", camSetting.AlignOffsetX);
            RWFile.WriteFile(Section, "AlignOffsetY", camSetting.AlignOffsetY);
            RWFile.WriteFile(Section, "AlignOffsetT", camSetting.AlignOffsetT);

            RWFile.WriteFile(Section, "CalOffsetX", camSetting.CalOffsetX);
            RWFile.WriteFile(Section, "CalOffsetY", camSetting.CalOffsetY);
            RWFile.WriteFile(Section, "CalOffsetT", camSetting.CalOffsetT);

            RWFile.WriteFile(Section, "LengthOffset1", camSetting.LengthOffset1);
            RWFile.WriteFile(Section, "LengthOffset2", camSetting.LengthOffset2);
        }

        void WriteCamLaser(ref CamSetting camSetting)
        {
            string Section = "OFFSET";

            RWFile.WriteFile(Section, "AlignOffsetX", camSetting.AlignOffsetX);
            RWFile.WriteFile(Section, "AlignOffsetY", camSetting.AlignOffsetY);
            RWFile.WriteFile(Section, "AlignOffsetT", camSetting.AlignOffsetT);

            RWFile.WriteFile(Section, "CalOffsetX", camSetting.CalOffsetX);
            RWFile.WriteFile(Section, "CalOffsetY", camSetting.CalOffsetY);
            RWFile.WriteFile(Section, "CalOffsetT", camSetting.CalOffsetT);

            RWFile.WriteFile(Section, "LengthOffset1", camSetting.LengthOffset1);
            RWFile.WriteFile(Section, "LengthOffset2", camSetting.LengthOffset2);
        }

        /// <summary>
        /// Viết giá trị từ Model vào Folder
        /// </summary>
        /// <returns></returns>
        public void WriteParameterToFolder()
        {
            try
            {
                string[] camNames = Enum.GetNames(typeof(eCamName));

                foreach (string camName in camNames)
                {
                    RWFile.RWFilePath = Path.Combine(PathRoot, camName, ConfigName);

                    CamSetting camSetting;

                    switch (camName)
                    {
                        case "LoadingPre1":
                            camSetting = LoadingPre1;
                            break;
                        case "LoadingPre2":
                            camSetting = LoadingPre2;
                            break;
                        case "Laser1":
                            camSetting = Laser1;
                            break;
                        case "Laser2":
                            camSetting = Laser2;
                            break;
                        default:
                            continue;
                    }

                    WriteCamSetting(ref camSetting);
                    WriteCamOffset(ref camSetting);
                    WriteCamLaser(ref camSetting);
                }

            }            
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


    }

}

