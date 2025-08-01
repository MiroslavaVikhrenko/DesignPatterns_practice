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
    // Can apply safe changes
    // If request.Index is between 0 and 4, the moderator cannot apply the change.
    // If request.Index is ≥ 5, the moderator can apply the change.
    public class ModeratorHandler : IRequestHandler
    {
        private readonly int _restrictedStart = 0;
        private readonly int _restrictedEnd = 5;

        public override bool Handle(EditRequest request, Document doc, History history)
        {
            if (request.Role == "moderator")
            {
                if (request.Index < _restrictedStart || request.Index >= _restrictedEnd)
                {
                    ICommand command = CreateCommand(request, doc);
                    if (command == null) return false;

                    history.Save(doc.Save());
                    command.Execute();
                    Console.WriteLine("Moderator applied safe change.");
                    return true;
                }

                Console.WriteLine("Cannot modify restricted zone (0–5).");
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
