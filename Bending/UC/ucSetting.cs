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
            eCamName camName = (eCamName)cboName.SelectedItem;
            if (camName == eCamName.LoadingPre1)
            {
                ReadCamSettingModelToView(LoadingPre1);
                ReadCamOffsetModelToView(LoadingPre1);
                ReadCamLaserModelToView(LoadingPre1);
            }
            if (camName == eCamName.LoadingPre2)
            {
                ReadCamSettingModelToView(LoadingPre2);
                ReadCamOffsetModelToView(LoadingPre2);
                ReadCamLaserModelToView(LoadingPre2);
            }
            if (camName == eCamName.Laser1)
            {
                ReadCamSettingModelToView(Laser1);
                ReadCamOffsetModelToView(Laser1);
                ReadCamLaserModelToView(Laser1);
            }
            if (camName == eCamName.Laser2)
            {
                ReadCamSettingModelToView(Laser2);
                ReadCamOffsetModelToView(Laser2);
                ReadCamLaserModelToView(Laser2);
            }

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
            if (camName == eCamName.LoadingPre1)
            {
                WriteCamSettingViewToModel(LoadingPre1);
                WriteCamOffsetViewToModel(LoadingPre1);
                WriteCamLaserViewToModel(LoadingPre1);
            }
            if (camName == eCamName.LoadingPre2)
            {
                WriteCamSettingViewToModel(LoadingPre2);
                WriteCamOffsetViewToModel(LoadingPre2);
                WriteCamLaserViewToModel(LoadingPre2);
            }
            if (camName == eCamName.Laser1)
            {
                WriteCamSettingViewToModel(Laser1);
                WriteCamOffsetViewToModel(Laser1);
                WriteCamLaserViewToModel(Laser1);
            }
            if (camName == eCamName.Laser2)
            {
                WriteCamSettingViewToModel(Laser2);
                WriteCamOffsetViewToModel(Laser2);
                WriteCamLaserViewToModel(Laser2);
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
            if (camName == eCamName.LoadingPre1)
            {
                ReadCamSettingModelToView(LoadingPre1);
                ReadCamOffsetModelToView(LoadingPre1);
                ReadCamLaserModelToView(LoadingPre1);
            }
            if (camName == eCamName.LoadingPre2)
            {
                ReadCamSettingModelToView(LoadingPre2);
                ReadCamOffsetModelToView(LoadingPre2);
                ReadCamLaserModelToView(LoadingPre2);
            }
            if (camName == eCamName.Laser1)
            {
                ReadCamSettingModelToView(Laser1);
                ReadCamOffsetModelToView(Laser1);
                ReadCamLaserModelToView(Laser1);
            }
            if (camName == eCamName.Laser2)
            {
                ReadCamSettingModelToView(Laser2);
                ReadCamOffsetModelToView(Laser2);
                ReadCamLaserModelToView(Laser2);
            }
        }

        void ReadCamSetting(  ref CamSetting camSetting)
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
                foreach (string camName in Enum.GetNames(typeof(eCamName)))
                {
                    RWFile.RWFilePath = Path.Combine(PathRoot, camName, ConfigName);

                    switch (camName)
                    {
                        case "LoadingPre1":
                            ReadCamSetting( ref LoadingPre1);
                            ReadCamOffset( ref LoadingPre1);
                            ReadCamLaser(ref LoadingPre1);
                            break;
                        case "LoadingPre2":
                            ReadCamSetting( ref LoadingPre2);
                            ReadCamOffset( ref LoadingPre2);
                            ReadCamLaser( ref LoadingPre2);
                            break;
                        case "Laser1":
                            ReadCamSetting(ref Laser1);
                            ReadCamOffset( ref Laser1);
                            ReadCamLaser(ref Laser1);
                            break;
                        case "Laser2":
                            ReadCamSetting(ref Laser2);
                            ReadCamOffset(ref Laser2);
                            ReadCamLaser(ref Laser2);
                            break;

                        default: break;

                    }

#if (test)

                    _camSetting.FOVX = RWFile.ReadFile(Section, "FOVX", "0");
                    _camSetting.FOVY = RWFile.ReadFile(Section, "FOVY", "0");

                    _camSetting.Resolution = RWFile.ReadFile(Section, "Resolution", "0");
                    _camSetting.Serial = RWFile.ReadFile(Section, "Serial", "0");

                    _camSetting.PatternSearchMode = int.Parse(RWFile.ReadFile(Section, "PatternSearchMode", "0"));
                    _camSetting.PatternSearchTool = int.Parse(RWFile.ReadFile(Section, "PatternSearchTool", "0"));

                    _camSetting.LightType = int.Parse(RWFile.ReadFile(Section, "LightType", "0"));
                    _camSetting.LighComport = RWFile.ReadFile(Section, "LighComport", "0");
                    _camSetting.LightChanel = RWFile.ReadFile(Section, "LightChanel", "0");

                    _camSetting.CameraReverse = int.Parse(RWFile.ReadFile(Section, "CameraReverse", "0"));
                    _camSetting.ImageSaveType = int.Parse(RWFile.ReadFile(Section, "ImageSaveType", "0"));

                    _camSetting.GrapDelay = RWFile.ReadFile(Section, "GrapDelay", "0");
                    _camSetting.LightDelay = RWFile.ReadFile(Section, "LightDelay", "0");

                    _camSetting.AlignLimitX = RWFile.ReadFile(Section, "AlignLimitX", "0");
                    _camSetting.AlignLimitY = RWFile.ReadFile(Section, "AlignLimitY", "0");
                    _camSetting.AlignLimitT = RWFile.ReadFile(Section, "AlignLimitT", "0");

                    _camSetting.RetryLimitCount = RWFile.ReadFile(Section, "RetryLimitCount", "0");
                    _camSetting.RetryCaptureCount = RWFile.ReadFile(Section, "RetryCaptureCount", "0");
                    _camSetting.ImageAutoDeleteDay = RWFile.ReadFile(Section, "ImageAutoDeleteDay", "0");

                    _camSetting.CenterAlign = int.Parse(RWFile.ReadFile(Section, "CenterAlign", "0"));


                    Section = "OFFSET";

                    _offset.AlignOffsetX = RWFile.ReadFile(Section, "AlignOffsetX", "0");
                    _offset.AlignOffsetY = RWFile.ReadFile(Section, "AlignOffsetY", "0");
                    _offset.AlignOffsetT = RWFile.ReadFile(Section, "AlignOffsetT", "0");

                    _offset.CalOffsetX = RWFile.ReadFile(Section, "CalOffsetX", "0");
                    _offset.CalOffsetY = RWFile.ReadFile(Section, "CalOffsetY", "0");
                    _offset.CalOffsetT = RWFile.ReadFile(Section, "CalOffsetT", "0");

                    _offset.LengthOffset1 = RWFile.ReadFile(Section, "LengthOffset1", "0");
                    _offset.LengthOffset2 = RWFile.ReadFile(Section, "LengthOffset2", "0");


                    Section = "LASER";

                    _laser.MarkPositionTolX = RWFile.ReadFile(Section, "MarkPositionTolX", "0");
                    _laser.MarkPositionTolY = RWFile.ReadFile(Section, "MarkPositionTolY", "0");

                    _laser.MaxSizeX = RWFile.ReadFile(Section, "MaxSizeX", "0");
                    _laser.MaxSizeY = RWFile.ReadFile(Section, "MaxSizeY", "0");
                    _laser.AlignRefSearch = int.Parse(RWFile.ReadFile(Section, "AlignRefSearch", "0"));
                    _laser.UseImageProcessing = int.Parse(RWFile.ReadFile(Section, "UseImageProcessing", "0"));

                    _laser.BlobSearchMaxPos = int.Parse(RWFile.ReadFile(Section, "BlobSearchMaxPos", "0"));
                    _laser.BlobBoxUsePoint = int.Parse(RWFile.ReadFile(Section, "BlobBoxUsePoint", "0"));
                    _laser.BlobPolarity = int.Parse(RWFile.ReadFile(Section, "BlobPolarity", "0"));
                    _laser.ConnectivityMinPixels = RWFile.ReadFile(Section, "ConnectivityMinPixels", "0");

                    _laser.MCRSearch = int.Parse(RWFile.ReadFile(Section, "MCRSearch", "0"));
                    _laser.MCRRight = int.Parse(RWFile.ReadFile(Section, "MCRRight", "0"));
                    _laser.MCRUp = int.Parse(RWFile.ReadFile(Section, "MCRUp", "0"));

                    _laser.InspectDegreeKind = int.Parse(RWFile.ReadFile(Section, "InspectDegreeKind", "0"));
                    _laser.LaserAlignRefPosTol = RWFile.ReadFile(Section, "LaserAlignRefPosTol", "0");

#endif
                }

            }
            catch (Exception)
            {
                throw;
            }
        }


        void WriteCamSetting(string camName, ref CamSetting camSetting)
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

        void WriteCamOffset(string camName, ref CamSetting camSetting)
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

        void WriteCamLaser(string camName, ref CamSetting camSetting)
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
                foreach (string camName in Enum.GetNames(typeof(eCamName)))
                {
                    RWFile.RWFilePath = Path.Combine(PathRoot, camName, ConfigName);

                    switch (camName)
                    {
                        case "LoadingPre1":
                            WriteCamSetting(camName, ref LoadingPre1);
                            WriteCamOffset(camName, ref LoadingPre1);
                            WriteCamLaser(camName, ref LoadingPre1);
                            break;
                        case "LoadingPre2":
                            WriteCamSetting(camName, ref LoadingPre2);
                            WriteCamOffset(camName, ref LoadingPre2);
                            WriteCamLaser(camName, ref LoadingPre2);
                            break;
                        case "Laser1":
                            WriteCamSetting(camName, ref Laser1);
                            WriteCamOffset(camName, ref Laser1);
                            WriteCamLaser(camName, ref Laser1);
                            break;
                        case "Laser2":
                            WriteCamSetting(camName, ref Laser2);
                            WriteCamOffset(camName, ref Laser2);
                            WriteCamLaser(camName, ref Laser2);
                            break;

                        default: break;

                    }

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

