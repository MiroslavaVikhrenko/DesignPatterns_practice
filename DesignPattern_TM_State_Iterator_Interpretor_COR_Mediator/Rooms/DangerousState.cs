using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Rooms
{
    //Concrete implementations of the State interface
    public class DangerousState : IRoomState
    {
        public void React()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Danger lurks in every shadow. Stay alert!");
            Console.ResetColor();
        }
    }
}
