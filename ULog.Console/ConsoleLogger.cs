using System;
using Ulog.Interfaces;

namespace ULog.Console
{
        public class ConsoleLogger : ILogger
        {
            public void Log(LogLevel logLevel, string msg)
            {
                var defaultColor = System.Console.ForegroundColor;
                System.Console.ForegroundColor = logLevel.ToConsoleColor();
                System.Console.WriteLine(msg);
                System.Console.ForegroundColor = defaultColor;
            }
        }
}
