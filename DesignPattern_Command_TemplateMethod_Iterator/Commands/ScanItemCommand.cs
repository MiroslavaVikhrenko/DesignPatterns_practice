using DesignPattern_Command_TemplateMethod_Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Command_TemplateMethod_Iterator.Commands
{
    public class ScanItemCommand : ICommand
    {
        public string Name => "Scan Item";
        public void Execute()
        {
            Console.WriteLine($"Executing {Name} Command");
        }
    }
}
