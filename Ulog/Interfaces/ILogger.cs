namespace Ulog.Interfaces
{
    public interface ILogger
    {
        void Log(LogLevel logLevel, string message);
    }
}
