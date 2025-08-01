using DesignPattern_Memento_Command_ChainOfResponsibility.Commands;
using DesignPattern_Memento_Command_ChainOfResponsibility.Core;
using DesignPattern_Memento_Command_ChainOfResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Memento_Command_ChainOfResponsibility.Users
{
    // Can apply anything
    public class AdminHandler : IRequestHandler
    {
        public override bool Handle(EditRequest request, Document doc, History history)
        {
            if (request.Role == "admin")
            {
                ICommand command = CreateCommand(request, doc);
                if (command == null) return false;

                history.Save(doc.Save());
                command.Execute();
                Console.WriteLine("Admin applied the change.");
                return true;
            }

            return Next?.Handle(request, doc, history) ?? false;
        }

        private ICommand CreateCommand(EditRequest r, Document d) =>
            r.Operation switch
            {
                "insert" => new InsertCommand(d, r.Index, r.Text),
                "delete" => new DeleteCommand(d, r.Index, r.Length),
                "replace" => new ReplaceCommand(d, r.Index, r.Length, r.Text),
                _ => null
            };
    }
}
