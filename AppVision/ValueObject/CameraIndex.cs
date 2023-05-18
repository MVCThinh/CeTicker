using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVision
{
    public class CameraIndex : ObservableObject
    {
        private int valueIndex;

        public CameraIndex()
        {
            valueIndex = 0;
        }

        public int Value
        {
            get { return valueIndex; }
            set { valueIndex = value; OnPropertyChanged("Value"); }
        }

        public override string ToString()
        {
            return "Camera " + base.ToString();
        }
    }
}
