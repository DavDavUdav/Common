using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULog.Console
{
    public static class LogLevelExtensions
    {
        public static ConsoleColor ToConsoleColor(this LogLevel level)
        {
            return level switch
            {
                LogLevel.Debug => ConsoleColor.Yellow,
                LogLevel.Info => ConsoleColor.Green,
                LogLevel.Warn => ConsoleColor.Yellow,
                LogLevel.Error => ConsoleColor.Red,
            };
        }
    }
}
