using System.IO;
using System.Text;
using Ulog.Interfaces;

namespace ULog.File
{
    public class FileLogger : ILogger
    {
        private FileSettings _settings;

        private string _path;

        public FileLogger(FileSettings settings)
        {
            _settings = settings;
            
            Directory.CreateDirectory(_settings.Path);
            
            _path = Path.Combine(_settings.Path, _settings.FileName);
        }

        public void Log(LogLevel logLevel, string message)
        {
            System.IO.File.AppendAllText(_path, message + "\n", Encoding.UTF8);
        }
    }
}
