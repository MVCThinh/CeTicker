using Cognex.VisionPro;
using Cognex.VisionPro.DSCameraSetup.Implementation.Internal;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.PMAlign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private CogPMAlignPattern pmAlignPattern;
        private CogPMAlignResult result;

        private void frmTest_Load(object sender, EventArgs e)
        {
            imageFileTool = new CogImageFileTool();
            pmAlignTool = new CogPMAlignTool();
            pmAlignPattern = new CogPMAlignPattern();
            result = new CogPMAlignResult();

            pmAlignTool.Ran += PmAlignTool_Ran;
            imageFileTool.Ran += ImageFileTool_Ran;
        }

        private void PmAlignTool_Ran(object sender, EventArgs e)
        {
            Display.InteractiveGraphics.Clear();
            Display.StaticGraphics.Clear();

            Display.Image = imageFileTool.OutputImage;
            result = pmAlignTool.Results[0];

            Display.StaticGraphics.Add(result.CreateResultGraphics(CogPMAlignResultGraphicConstants.All), "test");

            lbScore.Text = Math.Round(pmAlignTool.Results[0].Score, 2).ToString();

        }

        private void ImageFileTool_Ran(object sender, EventArgs e)
        {
            Display.InteractiveGraphics.Clear();
            Display.StaticGraphics.Clear();
            Display.AutoFit = true;
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

            Display.InteractiveGraphics.Add(ar, "Region Train", false);

            return ar;

        }

        private CogCoordinateAxes axes;
        private CogCoordinateAxes CreateAxes()
        {
            axes = new CogCoordinateAxes();
            axes.TipText = "Axes Pattern Train";
            axes.GraphicDOFEnable = CogCoordinateAxesDOFConstants.All | CogCoordinateAxesDOFConstants.Skew;
            axes.MouseCursor = CogStandardCursorConstants.ManipulableGraphic;
            axes.XAxisLabel.MouseCursor = CogStandardCursorConstants.ManipulableGraphic;
            axes.YAxisLabel.MouseCursor = CogStandardCursorConstants.ManipulableGraphic;

            Display.InteractiveGraphics.Add(axes, "Axes Train", false);

            return axes;

        }

        bool Settingup;
        private CogPMAlignPattern Pattern;
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


                pmAlignTool.Pattern = Pattern;
            }

        }



        bool PatternTrain = false;
        CogRectangleAffine rec;
        private void btnTrainPattern_Click(object sender, EventArgs e)
        {
            rec = new CogRectangleAffine();

            rec.SetOriginLengthsRotationSkew(Display.Width / 2, Display.Height / 2, 100, 100, 0, 0);
            rec = pmAlignPattern.TrainRegion as CogRectangleAffine;



            Display.InteractiveGraphics.Add(rec, "Train Region", false);
            Display.DrawingEnabled = true;

            if (!PatternTrain)
            {
                PatternTrain = true;
                btnTrainPattern.Text = "Train Pattern";
            }
            else
            {
                PatternTrain = false;
                btnTrainPattern.Text = "Create Region";

                pmAlignPattern.TrainImage = imageFileTool.OutputImage;
               pmAlignPattern.TrainRegion = rec;

                pmAlignPattern.TrainAlgorithm = CogPMAlignTrainAlgorithmConstants.PatMaxAndPatQuick;
                pmAlignPattern.TrainMode = CogPMAlignTrainModeConstants.Image;
                pmAlignPattern.TrainRegionMode = CogRegionModeConstants.PixelAlignedBoundingBox;

                pmAlignPattern.Origin.TranslationX = rec.CenterX;
                pmAlignPattern.Origin.TranslationY = rec.CenterY;

                pmAlignPattern.Train();


                Display.StaticGraphics.Clear();
                Display.StaticGraphics.AddList(pmAlignPattern.CreateGraphicsCoarse(CogColorConstants.Yellow), "test");
                //  Display.StaticGraphics.AddList(pmAlignPattern.CreateGraphicsFine(CogColorConstants.Cyan), "test2");

                cdPattern.InteractiveGraphics.Clear();
                cdPattern.StaticGraphics.Clear();
                cdPattern.Image = pmAlignPattern.GetTrainedPatternImage();
                cdPattern.StaticGraphics.AddList(pmAlignPattern.CreateGraphicsCoarse(CogColorConstants.Yellow), "test");

            }
        }

        private void btnRunPMAlign_Click(object sender, EventArgs e)
        {
            pmAlignTool.InputImage = imageFileTool.OutputImage;
            pmAlignTool.Pattern = pmAlignPattern;

            pmAlignTool.RunParams.RunAlgorithm = CogPMAlignRunAlgorithmConstants.BestTrained;
            pmAlignTool.RunParams.RunMode = CogPMAlignRunModeConstants.SearchImage;

            pmAlignTool.RunParams.ApproximateNumberToFind = 1;
            pmAlignTool.RunParams.AcceptThreshold = 0.5;

            pmAlignTool.RunParams.ZoneAngle.Configuration = CogPMAlignZoneConstants.LowHigh;
            pmAlignTool.RunParams.ZoneAngle.Low = -Math.PI/4;
            pmAlignTool.RunParams.ZoneAngle.High = Math.PI/4;

            pmAlignTool.RunParams.ZoneScale.Configuration = CogPMAlignZoneConstants.LowHigh;
            pmAlignTool.RunParams.ZoneScale.Low = 0.6;
            pmAlignTool.RunParams.ZoneScale.High = 1.6;

            pmAlignTool.Run();

            


        }
    }
}
