using DesignPattern_Memento_Command_ChainOfResponsibility.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Memento_Command_ChainOfResponsibility.Commands
{
    public class InsertCommand : ICommand
    {
        private readonly Document _document;
        private readonly int _index;
        private readonly string _text;

        public InsertCommand(Document document, int index, string text)
        {
            _document = document;
            _index = index;
            _text = text;
        }

        public void Execute() // inserts the text at a given index
        {
            _document.Insert(_index, _text);
        }

        public void Undo() // removes the same number of characters.
        {
            _document.Delete(_index, _text.Length);
        }
    }
}
