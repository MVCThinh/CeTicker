using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Models
{
    public class PLCSetting
    {
        public string PLCIP { get; set; }
        public string PLCStation { get; set; }
        public string PLCNetwork { get; set; }
        public string CalLengthX { get; set; }
        public string CalLengthY { get; set; }
        public string CalLengthR { get; set; }
        public bool Connected { get; set; }
    }
}
