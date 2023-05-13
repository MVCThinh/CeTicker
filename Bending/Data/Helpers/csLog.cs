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

        private string GetFormattedLogEntry(string logString)
        {
            return $"{DateTime.Now:dd-MM-yyyy__HH:mm:ss}:{DateTime.Now.Millisecond}---{logString}";
        }
        public void ExceptionLogSave(string logString)
        {
            try
            {
                string logDate = DateTime.Now.ToString("dd--MM-yyyy");
                string logHour = DateTime.Now.Hour.ToString();
                string logPath = Path.Combine(cExceptionLogPath, logDate);

                CreateLogPath(logPath);


                string logFolder = Path.Combine(logPath, logDate + "-" + logHour);
                string logEntry = GetFormattedLogEntry(logString);

                WirteLogToFolder(logFolder, logEntry);

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
                string logPath = Path.Combine(cSystemLogPath, logDate);


                CreateLogPath(logPath);


                string logFolder = Path.Combine(logPath, logDate + "-" + logHour);
                string logEntry = GetFormattedLogEntry(logString);

                WirteLogToFolder(logFolder, logEntry);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
