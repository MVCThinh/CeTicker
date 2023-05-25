using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.PMAlign;
using System.Windows.Forms;

namespace Bending.Foam
{
    public partial class frmAllTool : Form
    {

        private CogImageFileTool trainIDBTool;
        private CogImageFileTool testIDBTool;
        private CogPMAlignTool myPMTool;
        private CogPatInspectTool myPITool;

        public frmAllTool()
        {
            InitializeComponent();
        }
    }
}
