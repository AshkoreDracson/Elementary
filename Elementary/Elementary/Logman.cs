using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Elementary
{
    public static class Logman
    {
        private static FileStream _fileStream;

        public static ConsoleColor DebugLogColor { get; set; } = ConsoleColor.DarkGray;
        public static ConsoleColor InformationLogColor { get; set; } = ConsoleColor.Gray;
        public static ConsoleColor WarningLogColor { get; set; } = ConsoleColor.Yellow;
        public static ConsoleColor ErrorLogColor { get; set; } = ConsoleColor.Red;

        public static string FileOutputPath { get; set; } = "./log {0}.txt";

        public static bool IncludeDate { get; set; }
        public static bool IncludeTime { get; set; } = true;

        public static bool LogDebug { get; set; } = true;

        public static LogOptions LogOptions { get; set; } = LogOptions.ImmediateWindow;

        public static void Log(object o, LogLevel logLevel = LogLevel.Debug)
        {
            if (LogOptions == LogOptions.None) return;

            DateTime now = DateTime.Now;

            string str = string.Empty;
            if (IncludeDate || IncludeTime)
            {
                str += $"[{GetDateTimeString(now)}] ";
            }
            str += o;

            if (LogOptions.HasFlag(LogOptions.Console))
            {
                LogConsole(str, logLevel);
            }

            if (LogOptions.HasFlag(LogOptions.ImmediateWindow))
            {
                LogImmediate(str, logLevel);
            }

            if (LogOptions.HasFlag(LogOptions.File))
            {
                LogFile(str, logLevel);
            }
        }

        static void LogConsole(object o, LogLevel logLevel = LogLevel.Debug)
        {
            ConsoleColor oldColor = SwitchColor(logLevel);
            Console.WriteLine(o);
            Console.ForegroundColor = oldColor;
        }

        static void LogImmediate(object o, LogLevel logLevel = LogLevel.Debug)
        {
            Debug.WriteLine(o);
        }

        static void LogFile(object o, LogLevel logLevel = LogLevel.Debug)
        {
            if (_fileStream == null)
                _fileStream = new FileStream(string.Format(FileOutputPath, DateTime.Now.ToString("yyyy-M-dd--HH-mm-ss")), FileMode.Create, FileAccess.Write);

            byte[] bytes = Encoding.UTF8.GetBytes(o.ToString() + "\r\n");
            _fileStream.Write(bytes, 0, bytes.Length);
            _fileStream.Flush();
        }

        static string GetDateTimeString(DateTime now)
        {
            string[] strArr = new string[2] { null, null };

            if (IncludeDate)
                strArr[0] = now.ToShortDateString();

            if (IncludeTime)
                strArr[1] = now.ToString("HH:mm:ss.fff");

            return string.Join(" ", strArr).Trim();
        }

        static ConsoleColor SwitchColor(LogLevel logLevel)
        {
            ConsoleColor oldColor = Console.ForegroundColor;

            switch (logLevel)
            {
                case LogLevel.Debug:
                    Console.ForegroundColor = DebugLogColor;
                    break;
                case LogLevel.Information:
                    Console.ForegroundColor = InformationLogColor;
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = WarningLogColor;
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ErrorLogColor;
                    break;
                default:
                    break;
            }

            return oldColor;
        }
    }
}
