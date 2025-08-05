using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Adapter
{
    public class ReportGenerator
    {
        private readonly INewLogger _logger;

        public ReportGenerator(INewLogger logger)
        {
            _logger = logger;
        }
        public void GenerateReport()
        {
            _logger.LogInfo("Report created");
        }
    }
}
