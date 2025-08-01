using DesignPattern_Memento_Command_ChainOfResponsibility.Core;
using DesignPattern_Memento_Command_ChainOfResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Memento_Command_ChainOfResponsibility.Users
{
    // Suggests changes only
    public class UserHandler : IRequestHandler
    {
        public override bool Handle(EditRequest request, Document doc, History history)
        {
            if (request.Role == "user")
            {
                Console.WriteLine("User can only suggest changes. No changes applied.");
                return true;
            }

            return Next?.Handle(request, doc, history) ?? false;
        }
    }
}
