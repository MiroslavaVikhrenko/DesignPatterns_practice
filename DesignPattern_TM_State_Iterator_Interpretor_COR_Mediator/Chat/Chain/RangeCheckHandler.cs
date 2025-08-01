using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Chat.Chain
{
    public class RangeCheckHandler : ICommandHandler
    {
        public override bool Handle(CommandContext context)
        {
            // Stub check — assume all targets are in range
            Console.WriteLine("✔ Target is in range.");
            return Next?.Handle(context) ?? true;
        }
    }
}
