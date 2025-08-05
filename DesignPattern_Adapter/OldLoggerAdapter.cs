using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Adapter
{
    public class OldLoggerAdapter : INewLogger
    {
        private readonly OldLogger _oldLogger;

        public OldLoggerAdapter(OldLogger oldLogger)
        {
            _oldLogger = oldLogger;
        }
        public void LogError(string message)
        {
            _oldLogger.WriteLog($"[Error (old logger from adapter)]: {message}");
        }

        public void LogInfo(string message)
        {
            _oldLogger.WriteLog($"[Info (old logger from adapter)]: {message}");
        }
    }
}
