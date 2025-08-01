using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Memento_Command_ChainOfResponsibility.Core
{
    // Editable text + state
    public class Document
    {
        public string Content { get; private set; }

        public Document(string initialContent = "")
        {
            Content = initialContent;
        }

        public void Insert(int index, string text)
        {
            if (index < 0 || index > Content.Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            Content = Content.Insert(index, text); // string insert method
        }

        public void Delete(int index, int length)
        {
            if (index < 0 || index + length > Content.Length)
                throw new ArgumentOutOfRangeException();

            Content = Content.Remove(index, length);
        }

        public void Replace(int index, int length, string newText)
        {
            Delete(index, length);
            Insert(index, newText);
        }

        // Memento pattern: creates a snapshot of the current content
        public Memento Save() => new Memento(Content);

        // Memento pattern: restores a previous state
        public void Restore(Memento memento)
        {
            Content = memento.State;
        }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(">> Current Document Content:");
            Console.ResetColor();
            Console.WriteLine(Content);
        }
    }
}
