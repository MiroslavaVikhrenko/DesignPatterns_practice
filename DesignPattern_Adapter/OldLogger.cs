using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Adapter
{
    public class OldLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"[Old Logger]: {message}");
        }
    }
}
