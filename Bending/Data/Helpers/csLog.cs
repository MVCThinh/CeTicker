using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bending.Data.Helpers
{
    public class csLog
    {
        public static string cLogPath;
        public static string cExceptionLogPath;
        public static string cSystemLogPath;
        public static string cInspectionLogPath;
        public static int LogKeepDay = 30;


        private void CreateLogPath(string logPath)
        {
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }
        }

        private void WirteLogToFolder(string logPath, string logString)
        {
            using (var fileInfo = new StreamWriter(logPath, true))
            {
                fileInfo.WriteLine(logString);
                fileInfo.Flush();
            }
        }

        public void ExceptionLogSave(string logString)
        {
            try
            {
                logString = DateTime.Now.ToString("dd-MM-yyyy__HH:mm:ss") + ":" + DateTime.Now.Millisecond.ToString() + "---" + logString;

                string logDate = DateTime.Now.ToString("dd--MM-yyyy");
                string logHour = DateTime.Now.Hour.ToString();


                string logPath = cExceptionLogPath + "/" + logDate;
                CreateLogPath(logPath);


                string logFolder = logPath + "/" + logDate + "-" + logHour;
                WirteLogToFolder(logFolder, logString);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void LogSave(string logString)
        {
            try
            {
                logString = DateTime.Now.ToString("dd-MM-yyyy__HH:mm:ss") + ":" + DateTime.Now.Millisecond.ToString() + "---" + logString;

                string logDate = DateTime.Now.ToString("dd--MM-yyyy");
                string logHour = DateTime.Now.Hour.ToString();


                string logPath = cSystemLogPath + "/" + logDate;
                CreateLogPath(logPath);


                string logFolder = logPath + "/" + logDate + "-" + logHour;
                WirteLogToFolder(logFolder, logString);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
