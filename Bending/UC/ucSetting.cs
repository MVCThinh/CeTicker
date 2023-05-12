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

namespace Bending.UC
{
    public partial class ucSetting : UserControl
    {

        public static LoadingPre1 LoadingPre1 = new LoadingPre1();
        public static LoadingPre2 LoadingPre2 = new LoadingPre2();
        public static Laser1 Laser1 = new Laser1();
        public static Laser2 Laser2 = new Laser2();


        public static CamSettingModel _camSetting = new CamSettingModel();
        public static LaserModel _laser = new LaserModel();
        public static OffsetModel _offset = new OffsetModel();

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


        #region Đọc ghi dữ liệu từ Folder vào Setting

        /// <summary>
        /// Viết giá trị từ View vào Model
        /// </summary>
        public void WriteParameterViewToModel()
        {
            // CamSetting
            _camSetting.FOVX = txtFovX.Text;
            _camSetting.FOVY = txtFovY.Text;

            _camSetting.Resolution = txtResolution.Text;
            _camSetting.Serial = txtSerial.Text;

            _camSetting.PatternSearchMode = cbPatternSearchMode.SelectedIndex;
            _camSetting.PatternSearchTool = cbPatternSearchTool.SelectedIndex;

            _camSetting.CalType = cbCalType.SelectedIndex;
            _camSetting.LightType = cbLightType.SelectedIndex;
            _camSetting.LighComport = txtLight1Comport.Text;
            _camSetting.LightChanel = txtLight1CH.Text;

            _camSetting.CameraReverse = cbReverseMode.SelectedIndex;
            _camSetting.ImageSaveType = cbImageSaveType.SelectedIndex;

            _camSetting.GrapDelay = txtGrabDelay.Text;
            _camSetting.LightDelay = txtLightDelay.Text;

            _camSetting.AlignLimitX = txtAlignLimitX.Text;
            _camSetting.AlignLimitY = txtAlignLimitY.Text;
            _camSetting.AlignLimitT = txtAlignLimitT.Text;

            _camSetting.RetryLimitCount = txtAlignLimitCnt.Text;
            _camSetting.RetryCaptureCount = txtRetryCnt.Text;
            _camSetting.ImageAutoDeleteDay = txtImgAutoDelDay.Text;

            _camSetting.CenterAlign = Convert.ToInt32(cbCenterAlign.Checked);

            //Offset
            _offset.AlignOffsetX = txtAlignXOffset1.Text;
            _offset.AlignOffsetY = txtAlignYOffset1.Text;
            _offset.AlignOffsetT = txtAlignTOffset1.Text;

            _offset.CalOffsetX = txtCalXOffset.Text;
            _offset.CalOffsetY = txtCalYOffset.Text;
            _offset.CalOffsetT = txtCalTOffset.Text;

            _offset.LengthOffset1 = txtLengthOffset1.Text;
            _offset.LengthOffset2 = txtLengthOffset2.Text;


            //Laser
            _laser.MarkPositionTolX = txtMarkPosTorX.Text;
            _laser.MarkPositionTolY = txtMarkPosTorY.Text;
            _laser.MaxSizeX = txtMarkSizeX.Text;
            _laser.MaxSizeY = txtMarkSizeY.Text;

            _laser.AlignRefSearch = cbRefsearch.SelectedIndex;
            _laser.UseImageProcessing = Convert.ToInt32(cbImageProcessing.Checked);

            _laser.BlobSearchMaxPos = cbMassPosition.SelectedIndex;
            _laser.BlobBoxUsePoint = cbBlobBox.SelectedIndex;
            _laser.BlobPolarity = cbPolarity.SelectedIndex;
            _laser.ConnectivityMinPixels = txtMinPixel.Text;

            _laser.MCRSearch = cbMCRSearch.SelectedIndex;
            _laser.MCRRight = Convert.ToInt32(cbMCRRight.Checked);
            _laser.MCRUp = Convert.ToInt32(cbMCRUp.Checked);

            _laser.InspectDegreeKind = cbInspKind.SelectedIndex;
            _laser.LaserAlignRefPosTol = txtLaserAlignTor.Text;
        }

        /// <summary>
        /// Đẩy giá trị từ Model tới View
        /// </summary>
        public void ReadParameterModelToView()
        {
            // CamSetting
            txtFovX.Text = _camSetting.FOVX;
            txtFovY.Text = _camSetting.FOVY;

            txtResolution.Text = _camSetting.Resolution;
            txtSerial.Text = _camSetting.Serial;

            cbPatternSearchMode.SelectedIndex = _camSetting.PatternSearchMode;
            cbPatternSearchTool.SelectedIndex = _camSetting.PatternSearchTool;

            cbCalType.SelectedIndex = _camSetting.CalType;
            cbLightType.SelectedIndex = _camSetting.LightType;
            txtLight1Comport.Text = _camSetting.LighComport;
            txtLight1CH.Text = _camSetting.LightChanel;

            cbReverseMode.SelectedIndex = _camSetting.CameraReverse;
            cbImageSaveType.SelectedIndex = _camSetting.ImageSaveType;

            txtGrabDelay.Text = _camSetting.GrapDelay;
            txtLightDelay.Text = _camSetting.LightDelay;

            txtAlignLimitX.Text = _camSetting.AlignLimitX;
            txtAlignLimitY.Text = _camSetting.AlignLimitY;
            txtAlignLimitT.Text = _camSetting.AlignLimitT;

            txtAlignLimitCnt.Text = _camSetting.RetryLimitCount;
            txtRetryCnt.Text = _camSetting.RetryCaptureCount;
            txtImgAutoDelDay.Text = _camSetting.ImageAutoDeleteDay;

            cbCenterAlign.Checked = Convert.ToBoolean(_camSetting.CenterAlign);

            //Offset
            txtAlignXOffset1.Text = _offset.AlignOffsetX;
            txtAlignYOffset1.Text = _offset.AlignOffsetY;
            txtAlignTOffset1.Text = _offset.AlignOffsetT;

            txtCalXOffset.Text = _offset.CalOffsetX;
            txtCalYOffset.Text = _offset.CalOffsetY;
            txtCalTOffset.Text = _offset.CalOffsetT;

            txtLengthOffset1.Text = _offset.LengthOffset1;
            txtLengthOffset2.Text = _offset.LengthOffset2;


            //Laser
            txtMarkPosTorX.Text = _laser.MarkPositionTolX;
            txtMarkPosTorY.Text = _laser.MarkPositionTolY;
            txtMarkSizeX.Text = _laser.MaxSizeX;
            txtMarkSizeY.Text = _laser.MaxSizeY;

            cbRefsearch.SelectedIndex = _laser.AlignRefSearch;
            cbImageProcessing.Checked = Convert.ToBoolean(_laser.UseImageProcessing);

            cbMassPosition.SelectedIndex = _laser.BlobSearchMaxPos;
            cbBlobBox.SelectedIndex = _laser.BlobBoxUsePoint;
            cbPolarity.SelectedIndex = _laser.BlobPolarity;
            txtMinPixel.Text = _laser.ConnectivityMinPixels;

            cbMCRSearch.SelectedIndex = _laser.MCRSearch;
            cbMCRRight.Checked = Convert.ToBoolean(_laser.MCRRight);
            cbMCRUp.Checked = Convert.ToBoolean(_laser.MCRUp);

            cbInspKind.SelectedIndex = _laser.InspectDegreeKind;
            txtLaserAlignTor.Text = _laser.LaserAlignRefPosTol;
        }


        /// <summary>
        /// Đẩy giá trị từ Folder vào Model
        /// </summary>
        /// <returns></returns>
        public bool ReadParameterFormFolder()
        {

            string PathRoot = @"C:\EQData1\Config\";
            string ConfigName = "\\VisionConfig.ini";
           

            try
            {
                foreach (string camName in Enum.GetNames(typeof(eCamName)))
                {
                    RWFile.RWFilePath = Path.Combine(PathRoot, camName, ConfigName);
                }




                string Section = "CAMSETTING";

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



                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Viết giá trị từ Model vào Folder
        /// </summary>
        /// <returns></returns>
        public bool WriteParameterToFolder()
        {
            try
            {
                RWFile.RWFilePath = @"C:\EQData1\Config\VisionConfig.ini";

                string Section = "CAMSETTING";

                RWFile.WriteFile(Section, "FOVX", _camSetting.FOVX);
                RWFile.WriteFile(Section, "FOVY", _camSetting.FOVY);

                RWFile.WriteFile(Section, "Resolution", _camSetting.Resolution);
                RWFile.WriteFile(Section, "Serial", _camSetting.Serial);

                RWFile.WriteFile(Section, "PatternSearchMode", _camSetting.PatternSearchMode.ToString());
                RWFile.WriteFile(Section, "PatternSearchTool", _camSetting.PatternSearchTool.ToString());

                RWFile.WriteFile(Section, "CalType", _camSetting.CalType.ToString());
                RWFile.WriteFile(Section, "LightType", _camSetting.LightType.ToString());
                RWFile.WriteFile(Section, "LighComport", _camSetting.LighComport);
                RWFile.WriteFile(Section, "LightChanel", _camSetting.LightChanel);

                RWFile.WriteFile(Section, "CameraReverse", _camSetting.CameraReverse.ToString());
                RWFile.WriteFile(Section, "ImageSaveType", _camSetting.ImageSaveType.ToString());
                RWFile.WriteFile(Section, "GrapDelay", _camSetting.GrapDelay);
                RWFile.WriteFile(Section, "LightDelay", _camSetting.LightDelay);

                RWFile.WriteFile(Section, "AlignLimitX", _camSetting.AlignLimitX);
                RWFile.WriteFile(Section, "AlignLimitY", _camSetting.AlignLimitY);
                RWFile.WriteFile(Section, "AlignLimitT", _camSetting.AlignLimitT);

                RWFile.WriteFile(Section, "RetryLimitCount", _camSetting.RetryLimitCount);
                RWFile.WriteFile(Section, "RetryCaptureCount", _camSetting.RetryCaptureCount);
                RWFile.WriteFile(Section, "ImageAutoDeleteDay", _camSetting.ImageAutoDeleteDay);

                RWFile.WriteFile(Section, "CenterAlign", _camSetting.CenterAlign.ToString());


                Section = "LASER";

                RWFile.WriteFile(Section, "MarkPositionTolX", _laser.MarkPositionTolX);
                RWFile.WriteFile(Section, "MarkPositionTolY", _laser.MarkPositionTolY);

                RWFile.WriteFile(Section, "MaxSizeX", _laser.MaxSizeX);
                RWFile.WriteFile(Section, "MaxSizeY", _laser.MaxSizeY);

                RWFile.WriteFile(Section, "AlignRefSearch", _laser.AlignRefSearch.ToString());
                RWFile.WriteFile(Section, "UseImageProcessing", _laser.UseImageProcessing.ToString());

                RWFile.WriteFile(Section, "BlobSearchMaxPos", _laser.BlobSearchMaxPos.ToString());
                RWFile.WriteFile(Section, "BlobBoxUsePoint", _laser.BlobBoxUsePoint.ToString());
                RWFile.WriteFile(Section, "BlobPolarity", _laser.BlobPolarity.ToString());
                RWFile.WriteFile(Section, "ConnectivityMinPixels", _laser.ConnectivityMinPixels);

                RWFile.WriteFile(Section, "MCRSearch", _laser.MCRSearch.ToString());
                RWFile.WriteFile(Section, "MCRRight", _laser.MCRRight.ToString());
                RWFile.WriteFile(Section, "MCRUp", _laser.MCRUp.ToString());

                RWFile.WriteFile(Section, "InspectDegreeKind", _laser.InspectDegreeKind.ToString());
                RWFile.WriteFile(Section, "LaserAlignRefPosTol", _laser.LaserAlignRefPosTol);


                Section = "OFFSET";

                RWFile.WriteFile(Section, "AlignOffsetX", _offset.AlignOffsetX);
                RWFile.WriteFile(Section, "AlignOffsetY", _offset.AlignOffsetY);
                RWFile.WriteFile(Section, "AlignOffsetT", _offset.AlignOffsetT);

                RWFile.WriteFile(Section, "CalOffsetX", _offset.CalOffsetX);
                RWFile.WriteFile(Section, "CalOffsetY", _offset.CalOffsetY);
                RWFile.WriteFile(Section, "CalOffsetT", _offset.CalOffsetT);

                RWFile.WriteFile(Section, "LengthOffset1", _offset.LengthOffset1);
                RWFile.WriteFile(Section, "LengthOffset2", _offset.LengthOffset2);



                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }


        #endregion
    }
}
