using System;

namespace ULog
{
    public static class MessageBuilder
    {
        public static string Build(string msg, LogLevel level)
        {
            return $"[{DateTime.Now}] [{level.ToString()}] {msg}";
        }
    }
}
