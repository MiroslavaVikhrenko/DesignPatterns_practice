using DesignPattern_Memento_Command_ChainOfResponsibility.Core;
using DesignPattern_Memento_Command_ChainOfResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Memento_Command_ChainOfResponsibility.Users
{
    // Chain of Responsibility base
    public abstract class IRequestHandler
    {
        protected IRequestHandler Next;

        public void SetNext(IRequestHandler next) //  sets the next handler in the chain.
        {
            Next = next;
        }

        // Chain of Responsibility: attempts to handle the request
        public abstract bool Handle(EditRequest request, Document doc, History history);
    }
}
