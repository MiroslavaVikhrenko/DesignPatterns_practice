using DesignPattern_Command_TemplateMethod_Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Command_TemplateMethod_Iterator.Iterator
{
    public class TaskQueueIterator
    {
        private readonly Queue<ICommand> _commands;
        private int _index = 0;
        private readonly List<ICommand> _copy;

        public TaskQueueIterator(Queue<ICommand> commands)
        {
            _copy = commands.ToList();
        }

        public bool HasNext()
        {
            return _index < _copy.Count;
        }

        public ICommand Next()
        {
            return _copy[_index++];
        }
    }
}
