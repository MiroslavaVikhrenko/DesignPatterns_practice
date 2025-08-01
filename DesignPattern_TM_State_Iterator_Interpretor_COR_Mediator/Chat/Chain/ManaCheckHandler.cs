using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Chat.Chain
{
    public class ManaCheckHandler : ICommandHandler
    {
        public override bool Handle(CommandContext context)
        {
            if (context.Player.Mana < 30)
            {
                Console.WriteLine("❌ Not enough mana!");
                return false;
            }

            Console.WriteLine("✔ Mana check passed.");
            return Next?.Handle(context) ?? true;
        }
    }
}
