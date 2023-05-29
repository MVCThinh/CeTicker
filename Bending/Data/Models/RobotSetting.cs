using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Models
{
    public class RobotSetting
    {
        public string RobotIP { get; set; }
        public string RobotPort { get; set; }
        public bool Connected { get; set; }
    }
}
