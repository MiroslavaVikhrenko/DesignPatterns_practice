using DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Chat.Chain;
using DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Chat.Interpreter;
using DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Chat.Mediator;
using DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Chat
{
    public class ChatBot
    {
        private readonly ICommandInterpreter _interpreter;
        private readonly ICommandHandler _handlerChain;
        private readonly IChatMediator _mediator;

        public ChatBot(IChatMediator mediator)
        {
            _interpreter = new FantasyCommandInterpreter();
            _mediator = mediator;

            // Set up Chain of Responsibility: Mana → Range → Cooldown
            var mana = new ManaCheckHandler();
            var range = new RangeCheckHandler();
            var cooldown = new CooldownCheckHandler();

            mana.SetNext(range);
            range.SetNext(cooldown);

            _handlerChain = mana;
        }

        public void ProcessInput(string input, Player player)
        {
            var context = _interpreter.Interpret(input, player);
            if (context == null) return;

            if (_handlerChain.Handle(context))
            {
                Console.WriteLine($"{player.Name} casts {context.Spell} at {context.Target}!");
                player.Mana -= 30;
                player.CooldownTurns = 2;

                _mediator.Broadcast($"{player.Name} casts {context.Spell} at {context.Target}!", player.Name);
            }
        }
    }
}
