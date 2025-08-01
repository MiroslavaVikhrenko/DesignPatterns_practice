using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Memento_Command_ChainOfResponsibility.Commands
{
    // Base interface for all commands (Command Pattern)
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
