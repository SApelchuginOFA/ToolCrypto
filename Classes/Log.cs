using System;
using System.IO;

namespace CustomUtilities
{
    public enum LogMsgType
    {
        CRITICAL = 3,
        ERROR = 2,
        WARNING = 1,
        MESSAGE = 0
    }

    public static class Log
    {
        public static string LogDir = @".\logs\"; //defalt log dir
        public static string LogFile = @"log.log"; //defaut log file name
        public static string LogFileFullPath = $"{LogDir}{LogFile}"; //default full path

        public static bool UseCurrentDataInLogFileName = false;

        public static int MaxLevel = 0;

        public static void WriteFileLog(string strLog, LogMsgType logType = LogMsgType.MESSAGE)
        {
            string logFileName = LogFileFullPath;

            if (UseCurrentDataInLogFileName)
            {
                logFileName = $"{Log.LogDir}{DateTime.Now.ToString("yyyyMMdd")}.log";
            }

            if (!Directory.Exists(LogDir)) { Directory.CreateDirectory(LogDir); }


            if (logType == LogMsgType.CRITICAL)
                strLog = $"[{DateTime.Now.ToString("HH:mm:ss")}] CRITICAL: {strLog}";

            if (logType == LogMsgType.ERROR)
                strLog = $"[{DateTime.Now.ToString("HH:mm:ss")}] ERROR: {strLog}";

            if (logType == LogMsgType.WARNING)
                strLog = $"[{DateTime.Now.ToString("HH:mm:ss")}] WARNING: {strLog}";

            if (logType == LogMsgType.MESSAGE)
                strLog = $"[{DateTime.Now.ToString("HH:mm:ss")}] MESSAGE: {strLog}";

            if ((int)logType >= Log.MaxLevel)
                Log.WriteTextFile(logFileName, strLog);
        }

        public static void WriteTextFile(string fileFullName, string strLine)
        {
            strLine = strLine.TrimEnd(Environment.NewLine.ToCharArray());

            Console.WriteLine(strLine);

            try
            {
                if (File.Exists(fileFullName))
                {
                    using (StreamWriter sw = File.AppendText(fileFullName))
                    {
                        sw.WriteLine(strLine);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(fileFullName))
                    {
                        sw.WriteLine(strLine);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.WriteFileLog($"File: [{fileFullName}]", LogMsgType.ERROR);
                Log.WriteFileLog($"{ex.Message}", LogMsgType.ERROR);
            }
        }

    }
}
