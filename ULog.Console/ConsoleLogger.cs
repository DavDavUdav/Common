using System;
using Ulog.Interfaces;

namespace ULog.Console
{
    public class ConsoleLogger : ILogger
    {
        public void Log(LogLevel logLevel, string msg)
        {
            System.Console.ForegroundColor = logLevel.ToConsoleColor();
            System.Console.WriteLine(MessageBuilder.Build(msg, logLevel));
            System.Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
