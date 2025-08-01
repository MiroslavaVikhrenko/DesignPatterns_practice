using DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Chat.Interpreter
{
    public class FantasyCommandInterpreter : ICommandInterpreter
    {
        // Very simple command parser for "cast fireball at goblin"
        public CommandContext Interpret(string input, Player player)
        {
            var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length < 4 || tokens[0] != "cast")
            {
                Console.WriteLine("❌ Unrecognized command format.");
                return null;
            }

            return new CommandContext
            {
                Player = player,
                Action = tokens[0],
                Spell = tokens[1],
                Target = tokens[^1] //  syntax for "last item in array" 
            };
        }
    }
}
