using DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Chat
{
    // Holds parsed data from the interpreter.
    public class CommandContext
    {
        public Player Player { get; set; }
        public string Action { get; set; }     // e.g., "cast"
        public string Spell { get; set; }      // e.g., "fireball"
        public string Target { get; set; }     // e.g., "goblin"
    }
}
