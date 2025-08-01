using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Memento_Command_ChainOfResponsibility.Core
{
    // Acts as the Caretaker for Memento. Manages undo history.
    public class History
    {
        private readonly Stack<Memento> _history = new(); // LIFO collection for storing mementos

        public void Save(Memento memento)
        {
            _history.Push(memento);
        }

        public Memento Undo()
        {
            return _history.Count > 0 ? _history.Pop() : null;
        }

        public bool CanUndo => _history.Count > 0;
    }
}
