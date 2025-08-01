using DesignPattern_Memento_Command_ChainOfResponsibility.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Memento_Command_ChainOfResponsibility.Commands
{
    public class DeleteCommand : ICommand
    {
        private readonly Document _document;
        private readonly int _index;
        private readonly int _length;
        private string _deletedText; // Stores the deleted text so it can be restored during Undo()

        public DeleteCommand(Document document, int index, int length)
        {
            _document = document;
            _index = index;
            _length = length;
        }

        public void Execute()
        {
            _deletedText = _document.Content.Substring(_index, _length);
            _document.Delete(_index, _length);
        }

        public void Undo()
        {
            _document.Insert(_index, _deletedText);
        }
    }
}
