using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Rooms
{
    // Concrete rooms inheriting the Template Method
    public class ForestRoom : AbstractRoom
    {
        public ForestRoom(IRoomState state) : base(state) { }

        protected override void Describe()
        {
            Console.WriteLine("You see towering trees and hear distant birds.");
        }

        protected override void ShowActions()
        {
            Console.WriteLine("Actions: [explore] [rest]");
        }
    }
}
