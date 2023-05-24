using Cognex.VisionPro;
using Cognex.VisionPro.DSCameraSetup.Implementation.Internal;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.PMAlign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bending.Foam
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }


        private CogImageFileTool imageFileTool;
        private CogPMAlignTool pmAlignTool;
     
        private void frmTest_Load(object sender, EventArgs e)
        {
            imageFileTool= new CogImageFileTool();
            pmAlignTool = new CogPMAlignTool();



            imageFileTool.Ran += ImageFileTool_Ran;
        }



        private void ImageFileTool_Ran(object sender, EventArgs e)
        {
            Display.InteractiveGraphics.Clear();
            Display.Image = imageFileTool.OutputImage;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                imageFileTool.Operator.Open(ofd.FileName, CogImageFileModeConstants.Read);
                Display.AutoFit = true;
                imageFileTool.Run();
            }
        }

        private void btnNextFile_Click(object sender, EventArgs e)
        {
            imageFileTool.Run();

        }

        private void btnCreateRegion_Click(object sender, EventArgs e)
        {
            int originX, originY;


            pmAlignTool.InputImage = Display.Image;

            Display.DrawingEnabled = false;
            CogRectangleAffine rectangleAffine = (CogRectangleAffine)pmAlignTool.Pattern.TrainRegion;
            rectangleAffine.TipText = "Rectange Pattern Train";
            rectangleAffine.GraphicDOFEnable = CogRectangleAffineDOFConstants.Position |
                                                CogRectangleAffineDOFConstants.Rotation |
                                                CogRectangleAffineDOFConstants.Size;

            originX = Display.Width / 2;
            originY = Display.Height / 2;

            rectangleAffine.SetOriginLengthsRotationSkew(originX, originY, 100, 100, 0, 0);


            Display.InteractiveGraphics.Add(rectangleAffine, "Region Train", false);

            rectangleAffine.MouseCursor = CogStandardCursorConstants.ManipulableGraphic;

            Display.DrawingEnabled = true;






        }

        private CogRectangleAffine ar;
        private CogRectangleAffine CreateRectange()
        {
            ar = new CogRectangleAffine();
            ar.TipText = "Rectange Pattern Train";
            ar.GraphicDOFEnable = CogRectangleAffineDOFConstants.Position |
                                    CogRectangleAffineDOFConstants.Rotation |
                                      CogRectangleAffineDOFConstants.Size;
            ar.SetCenterLengthsRotationSkew(Display.Width / 2, Display.Height / 2, 100, 100, 0, 0);
            ar.MouseCursor = CogStandardCursorConstants.ManipulableGraphic;

            Display.InteractiveGraphics.Add(ar, "Region Train", false) ;

            return ar;
            
        }

        private CogCoordinateAxes axes;
        private CogCoordinateAxes CreateAxes()
        {
            axes= new CogCoordinateAxes();
            axes.TipText = "Axes Pattern Train";
            axes.GraphicDOFEnable = CogCoordinateAxesDOFConstants.All | CogCoordinateAxesDOFConstants.Skew;
            axes.MouseCursor = CogStandardCursorConstants.ManipulableGraphic;
            axes.XAxisLabel.MouseCursor = CogStandardCursorConstants.ManipulableGraphic;
            axes.YAxisLabel.MouseCursor = CogStandardCursorConstants.ManipulableGraphic;

            Display.InteractiveGraphics.Add(axes, "Axes Train", false);

            return axes;

        }

        bool Settingup;
        private void btnSettingUp_Click(object sender, EventArgs e)
        {
            if (!Settingup)
            {
                Settingup = true;
                Display.DrawingEnabled = false;

                pmAlignTool.InputImage = imageFileTool.OutputImage;
                CogRectangleAffine ar = (CogRectangleAffine)pmAlignTool.Pattern.TrainRegion;
                //ar.GraphicDOFEnable = CogRectangleAffineDOFConstants.Position |
                //                        CogRectangleAffineDOFConstants.Rotation |
                //                        CogRectangleAffineDOFConstants.Size;
                ar.SetOriginLengthsRotationSkew(Display.Width / 2, Display.Height / 2, 100, 100, 0, 0);
                
                Display.DrawingEnabled = true;

                Display.InteractiveGraphics.Add(ar, "Train Pattern", false);


                pmAlignTool.Pattern.Origin.TranslationX = ar.CenterX;
                pmAlignTool.Pattern.Origin.TranslationY = ar.CenterY;



                pmAlignTool.RunParams.ApproximateNumberToFind = 1;
                pmAlignTool.RunParams.ZoneAngle.Configuration = CogPMAlignZoneConstants.LowHigh;
                pmAlignTool.RunParams.ZoneAngle.Low = -Math.PI;
                pmAlignTool.RunParams.ZoneAngle.High = Math.PI;



            }
            else
            {
                Settingup = false;
                pmAlignTool.Pattern.TrainImage = pmAlignTool.InputImage;
                pmAlignTool.Pattern.Train();
                pmAlignTool.Run();
                if (pmAlignTool.RunStatus.Result == CogToolResultConstants.Error)
                    MessageBox.Show(pmAlignTool.RunStatus.Message);
                lbScore.Text = pmAlignTool.Results[0].Score.ToString();

                lbX.Text = pmAlignTool.Results[0].GetPose().TranslationX.ToString("#.##");
                lbY.Text = pmAlignTool.Results[0].GetPose().TranslationY.ToString("#.##");
                lbT.Text = pmAlignTool.Results[0].GetPose().Rotation.ToString("#.##");
            }

        }
    }
}
