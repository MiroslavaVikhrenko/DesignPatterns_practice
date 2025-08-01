using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Rooms
{
    // Concrete rooms inheriting the Template Method
    public class CaveRoom : AbstractRoom
    {
        public CaveRoom(IRoomState state) : base(state) { }

        protected override void Describe()
        {
            Console.WriteLine("A damp, dark cave stretches before you.");
        }

        protected override void ShowActions()
        {
            Console.WriteLine("Actions: [light torch] [advance]");
        }
    }
}
