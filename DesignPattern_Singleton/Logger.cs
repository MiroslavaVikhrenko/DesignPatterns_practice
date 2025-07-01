using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Singleton
{
    public class Logger
    {
        private static Logger _logger; // Changed to static to resolve CS0120  
        private readonly string _logFilePath;

        private Logger()
        {
            _logFilePath = "log.txt";
        }

        public static Logger GetInstance()
        {
            if (_logger == null)
            {
                _logger = new Logger();
            }
            return _logger;
        }
        public void Log(string message)
        {
            string messageWithDateTime = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}\n";
            File.AppendAllText(_logFilePath, messageWithDateTime);
        }
    }
}
