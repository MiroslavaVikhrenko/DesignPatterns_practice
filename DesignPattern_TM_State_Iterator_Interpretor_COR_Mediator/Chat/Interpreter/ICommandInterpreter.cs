using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Chat.Interpreter
{
    // Interpreter Pattern: defines interface for command interpretation
    public interface ICommandInterpreter
    {
        CommandContext Interpret(string input, Models.Player player);
    }
}
