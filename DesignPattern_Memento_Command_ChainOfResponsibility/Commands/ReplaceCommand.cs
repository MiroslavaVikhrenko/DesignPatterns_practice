using DesignPattern_Memento_Command_ChainOfResponsibility.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Memento_Command_ChainOfResponsibility.Commands
{
    public class ReplaceCommand : ICommand
    {
        private readonly Document _document;
        private readonly int _index;
        private readonly int _length;
        private readonly string _newText;
        private string _oldText;

        public ReplaceCommand(Document document, int index, int length, string newText)
        {
            _document = document;
            _index = index;
            _length = length;
            _newText = newText;
        }

        public void Execute()
        {
            _oldText = _document.Content.Substring(_index, _length); // Captures the original text before replacing it.
            _document.Replace(_index, _length, _newText);
        }

        public void Undo()
        {
            _document.Replace(_index, _newText.Length, _oldText); // replacing it back with the old version
        }
    }
}
