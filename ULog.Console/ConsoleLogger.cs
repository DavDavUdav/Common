using System;
using Ulog.Interfaces;

namespace ULog.Console
{
    public class ConsoleLogger : ILogger
    {
        public void Log(LogLevel logLevel, string message)
        {
            System.Console.ForegroundColor = GetColor(logLevel);
            System.Console.WriteLine(message);
            System.Console.ForegroundColor = ConsoleColor.Gray;
        }

        private ConsoleColor GetColor(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Debug:
                    return ConsoleColor.Gray;
                case LogLevel.Info:
                    return ConsoleColor.Green;
                case LogLevel.Warn:
                    return ConsoleColor.Yellow;
                case LogLevel.Error:
                    return ConsoleColor.Red;
            }
            return ConsoleColor.Gray;
        }
    }
}
