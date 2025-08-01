using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Rooms
{
    //Concrete implementations of the State interface
    public class CalmState : IRoomState
    {
        public void React()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The room feels calm and quiet.");
            Console.ResetColor();
        }
    }
}
