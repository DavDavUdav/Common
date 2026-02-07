using System.Collections.Generic;
using Ulog.Interfaces;

namespace Ulog
{
    public static class Log
    {
        public static List<ILogger> Loggers = new List<ILogger>();

        public static void Debug(string msg) => Write(LogLevel.Debug, msg);
        public static void Info(string msg) => Write(LogLevel.Info, msg);
        public static void Warn(string msg) => Write(LogLevel.Warn, msg);
        public static void Error(string msg) => Write(LogLevel.Error, msg);

        private static void Write(LogLevel logLevel, string msg)
        {
            foreach (var logger in Loggers)
            {
                logger.Log(logLevel, msg);
            }
        }
    }
}
