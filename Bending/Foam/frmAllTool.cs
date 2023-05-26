using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.PMAlign;
using System;
using System.Windows.Forms;

namespace Bending.Foam
{
    public partial class frmAllTool : Form
    {

        private CogImageFileTool ImageFileTool;
        private CogPMAlignTool PMAlignTool;
        private CogAcqFifoTool AcqFifoTool;

        bool SettingUp;

        public enum SettingUpConstants
        {
            settingUpPatMax,
            settingLiveVideo
        }

        public frmAllTool()
        {
            InitializeComponent();
        }

        private void rbFramGrapbber_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbFramGrapbber.Checked)
            {
                btnOpenFile.Text = "Live Video";
                btnNextImage.Text = "Capture Image";
            }
            else
            {
                btnOpenFile.Text = "Open File";
                btnNextImage.Text = "Next Image";
            }
        }

        int numAcq = 0;
        private void btnOpenFile_Click(object sender, System.EventArgs e)
        {
            cdDisplay.StaticGraphics.Clear();
            cdDisplay.InteractiveGraphics.Clear();

            AcqFifoTool = new CogAcqFifoTool();
            if (AcqFifoTool.Operator == null)
            {
                rbFramGrapbber.Enabled = false;
            }

            if (rbFramGrapbber.Checked)
            {
                if (cdDisplay.LiveDisplayRunning)
                {
                    cdDisplay.StopLiveDisplay();
                    EnableAll(SettingUpConstants.settingLiveVideo);
                    AcqFifoTool.Run();
                }
                else if (AcqFifoTool.Operator != null){
                    cdDisplay.StartLiveDisplay(AcqFifoTool.Operator, false);
                    DisableAll(SettingUpConstants.settingLiveVideo);
                }
            }
            else
            {

            }

            // Thay thế event Ran;
            while (AcqFifoTool.RunStatus.Result == CogToolResultConstants.Accept)
            {
                cdDisplay.InteractiveGraphics.Clear();
                cdDisplay.StaticGraphics.Clear();

                cdDisplay.Image = AcqFifoTool.OutputImage;
                PMAlignTool.InputImage = AcqFifoTool.OutputImage as CogImage8Grey;
                ImageFileTool.InputImage = AcqFifoTool.OutputImage;

                numAcq += 1;
                if (numAcq > 4)
                {
                    GC.Collect();
                    numAcq = 0;
                }
            }
        }

        private void EnableAll(SettingUpConstants settings)
        {
            gbImageAcquisition.Enabled = true;
            gbPatMax.Enabled = true;
            if (settings == SettingUpConstants.settingUpPatMax)
            {
                btnSetupPatMax.Text = "Setup";
                btnPatMaxRun.Enabled = true;
            }
            else if ( settings == SettingUpConstants.settingLiveVideo)
            {
                btnOpenFile.Text = "Live Video";
                btnNextImage.Enabled = true;
                rbFramGrapbber.Enabled = true;
                rbImageFile.Enabled = true;
            }

            
        }

        private void DisableAll(SettingUpConstants settings)
        {
            gbImageAcquisition.Enabled = false;
            gbPatMax.Enabled = false;

            if (settings == SettingUpConstants.settingUpPatMax)
            {
                gbPatMax.Enabled = true;
                btnSetupPatMax.Text = "OK";
                btnPatMaxRun.Enabled = false;
            }
            else if (settings == SettingUpConstants.settingLiveVideo)
            {
                gbImageAcquisition.Enabled = true;
                btnOpenFile.Text = "Stop Video";
                btnNextImage.Enabled = false;
                rbFramGrapbber.Enabled = false;
                rbImageFile.Enabled = false;
            }
        }

        private void tcAllTools_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            for (int i = 0; i < tcAllTools.TabPages.Count; i++)
            {
                if (i == tcAllTools.SelectedIndex)
                {
                    tcAllTools.TabPages[i].Enabled = true;
                }
                else
                {
                    tcAllTools.TabPages[i].Enabled = false;
                }
            }
        }

        private void tbPMAlign_Enter(object sender, System.EventArgs e)
        {
            SettingUp = false;
            txtInfo.Text = "Đây là ví dụ về PMAling Tool";
            
        }

    }
}
