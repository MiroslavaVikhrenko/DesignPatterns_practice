using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Memento_Command_ChainOfResponsibility.Core
{
    // Memento for document snapshots
    // Memento: a simple object that stores document state
    public class Memento
    {
        public string State { get; } //content of the document

        public Memento(string state)
        {
            State = state;
        }
    }
}
