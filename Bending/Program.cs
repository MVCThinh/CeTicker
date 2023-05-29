using Bending.Foam;
using Cognex.VisionPro.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bending
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());

            // Giải phóng framGrabbers
            CogFrameGrabbers cogFrameGrabbers = new CogFrameGrabbers();
            for (int i = 0; i < cogFrameGrabbers.Count; i++)
            {
                cogFrameGrabbers[i].Disconnect(false);
            }
        }
    }
}
