using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Chat.Chain
{
    // // Chain of Responsibility: defines the structure for command validation handlers
    public abstract class ICommandHandler
    {
        protected ICommandHandler Next;

        public void SetNext(ICommandHandler next)
        {
            Next = next;
        }

        public abstract bool Handle(CommandContext context);
    }
}
