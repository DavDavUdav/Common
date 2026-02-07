using System.Collections.Generic;
using Ulog.Interfaces;

namespace Ulog
{
    public static class Log
    {
        private static readonly List<ILogger> _Loggers = new List<ILogger>();
        
        public static IReadOnlyCollection<ILogger> Loggers => _Loggers;

        public static void AddLogger(ILogger logger) => _Loggers.Add(logger);
        public static void RemoveLogger(ILogger logger) => _Loggers.Remove(logger);

        public static void Debug(string msg) => Write(LogLevel.Debug, msg);
        public static void Info(string msg) => Write(LogLevel.Info, msg);
        public static void Warn(string msg) => Write(LogLevel.Warn, msg);
        public static void Error(string msg) => Write(LogLevel.Error, msg);

        private static void Write(LogLevel logLevel, string msg)
        {
            foreach (var logger in _Loggers)
            {
                logger.Log(logLevel, msg);
            }
        }
    }
}
