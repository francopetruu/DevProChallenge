using System;

    public class Logger
    {

        public enum LogLevel
        {
            DEBUG,
            INFO,
            WARN,
            ERROR,
            CRITICAL
        }

        public static void LogMessage(string filePath, string message, LogLevel level)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logMessage = $"[{timestamp}] [{level}] {message}";

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(logMessage);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Not able to write on file: " + e.Message);
            }

        }
    }