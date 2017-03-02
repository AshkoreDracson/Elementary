using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Elementary
{
    public static class Logman
    {
        private static FileStream _fileStream;

        /// <summary>
        /// The console color to use when logging debug messages
        /// </summary>
        public static ConsoleColor DebugLogColor { get; set; } = ConsoleColor.DarkGray;
        /// <summary>
        /// The console color to use when logging information messages
        /// </summary>
        public static ConsoleColor InformationLogColor { get; set; } = ConsoleColor.Gray;
        /// <summary>
        /// The console color to use when logging warning messages
        /// </summary>
        public static ConsoleColor WarningLogColor { get; set; } = ConsoleColor.Yellow;
        /// <summary>
        /// The console color to use when logging error messages
        /// </summary>
        public static ConsoleColor ErrorLogColor { get; set; } = ConsoleColor.Red;

        /// <summary>
        /// The file output path when logging towards a file, you can use {0} for string formatting, it'll automatically supply the date and time
        /// </summary>
        public static string FileOutputPath { get; set; } = "./log {0}.txt";

        /// <summary>
        /// Includes the date in the log messages
        /// </summary>
        public static bool IncludeDate { get; set; }
        /// <summary>
        /// Includes the time in the log messages
        /// </summary>
        public static bool IncludeTime { get; set; } = true;

        /// <summary>
        /// Logs debug messages, if false, debug messages are not logged.
        /// </summary>
        public static bool LogDebug { get; set; } = true;

        /// <summary>
        /// Log options enum, decides where logging should output
        /// </summary>
        public static LogOutput LogOutput { get; set; } = LogOutput.ImmediateWindow;

        /// <summary>
        /// Logs a message
        /// </summary>
        /// <param name="o">The object</param>
        /// <param name="logLevel">The log level of the message</param>
        public static void Log(object o, LogLevel logLevel = LogLevel.Debug)
        {
            if (LogOutput == LogOutput.None) return;
            if (logLevel == LogLevel.Debug && !LogDebug) return;

            DateTime now = DateTime.Now;

            string str = string.Empty;
            if (IncludeDate || IncludeTime)
            {
                str += $"[{GetDateTimeString(now)}] ";
            }
            str += o;

            if (LogOutput.HasFlag(LogOutput.Console))
            {
                LogConsole(str, logLevel);
            }

            if (LogOutput.HasFlag(LogOutput.ImmediateWindow))
            {
                LogImmediate(str, logLevel);
            }

            if (LogOutput.HasFlag(LogOutput.File))
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
