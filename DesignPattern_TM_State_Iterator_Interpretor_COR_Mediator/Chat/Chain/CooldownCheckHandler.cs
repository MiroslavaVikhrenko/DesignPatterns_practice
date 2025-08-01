using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Chat.Chain
{
    public class CooldownCheckHandler : ICommandHandler
    {
        public override bool Handle(CommandContext context)
        {
            if (context.Player.CooldownTurns > 0)
            {
                Console.WriteLine("❌ Spell is on cooldown.");
                return false;
            }

            Console.WriteLine("✔ Cooldown check passed.");
            return Next?.Handle(context) ?? true;
        }
    }
}
