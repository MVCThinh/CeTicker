using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Models
{
    public class FolderPath
    {
        public string cSideVisionPath { get; set; }
        public string cImagePath { get; set; }
        public string cVisionPath { get; set; }
        public string cRecipeSavePath { get; set; }
        public string cTracePath { get; set; }
        public string cMotionTracePath { get; set; }
        public string cConfigSavePath { get; set; }
        public string cDefaultDataPath { get; set; }
        public string cLogPath { get; set; }
        public string cExceptionLogPath { get; set; }
        public string cSystemLogPath { get; set; }
        public string cInspectionLogPath { get; set; }
    }
}
