using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Adapter
{
    public interface INewLogger
    {
        void LogInfo(string message);
        void LogError(string message);
    }
}
