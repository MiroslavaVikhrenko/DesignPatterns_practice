using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Command_TemplateMethod_Iterator.Interfaces
{
    public interface ICommand
    {
        string Name { get; }
        void Execute();
    }
}
