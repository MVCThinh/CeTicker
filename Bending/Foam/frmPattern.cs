using Bending.UC;
using Cognex.VisionPro;
using Cognex.VisionPro.Display;
using Cognex.VisionPro.FGGigE;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.PMAlign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bending.Foam
{
    public partial class frmPattern : Form
    {

        // Lấy tất cả Camera đang kết nôi.
        public static CogFrameGrabbers frameGrabbers;
        public static ICogFrameGrabber[] frameGrabber;


        CogImageFileTool ImageFileTool;
        CogPMAlignTool PatSearchTool;
        CogAcqFifoTool AcqFifoTool;
        bool SettingUp;


        public frmPattern()
        {
            InitializeComponent();


            cboCamName.DataSource = Enum.GetValues(typeof(eCamName));
        }

        private void frmPattern_Load(object sender, EventArgs e)
        {
            SettingUp = false;

            ImageFileTool = new CogImageFileTool();


        }



        // Lấy được tất cả cam. Lưu vào frameGrabber
        public void GetConnectedCameras()
        {
            frameGrabbers = new CogFrameGrabbers();

            int cameraCount = frameGrabbers.Count;
            frameGrabber = new ICogFrameGrabber[cameraCount];

            if (cameraCount > 0)
            {
                for (int i = 0; i < cameraCount; i++)
                {
                    frameGrabber[i] = frameGrabbers[i];
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy camera nào đang kết nối. \n\r" +
                    "Kiểm tra lại IP Camera trong phần mềm Cognex GigE Vision Configurator");
            }
        }

        public void LoadCameras(ICogFrameGrabber frameGrabber)
        {
           
        }





        private void ImageAcquisitionOption_CheckedChanged(object sender, EventArgs e)
        {
            if (optImageAcquisitionOptionFrameGrabber.Checked)
            {
                cmdImageAcquisitionLiveOrOpenCommand.Text = "Live Video";
                cmdImageAcquisitionNewImageCommand.Text = "New Image";
            }
            else if (optImageAcquisitionOptionImageFile.Checked)
            {
                cmdImageAcquisitionLiveOrOpenCommand.Text = "Open File";
                cmdImageAcquisitionNewImageCommand.Text = "Next Image";
            }
        }

        private void cmdImageAcquisitionLiveOrOpenCommand_Click(object sender, EventArgs e)
        {
            // Xóa các graphics
            cogDisplay.StaticGraphics.Clear();
            cogDisplay.InteractiveGraphics.Clear();


        }


    }
}
