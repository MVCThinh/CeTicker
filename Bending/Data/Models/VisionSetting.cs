using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Models.Setting
{
    public class VisionSetting
    {
        public static string SerialLoading1 { get; set; }
        public static string SerialLoading2 { get; set; }
        public static string SerialLaser1 { get; set; }
        public static string SerialLaser2 { get; set; }
        public static bool ConnectedLoadingPre1 { get; set; }
        public static bool ConnectedLoadingPre2 { get; set; }
        public static bool ConnectedLaser1 { get; set; }
        public static bool ConnectedLaser2 { get; set; }

    }
}
