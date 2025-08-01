using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Rooms
{
    // Template Method pattern
    public abstract class AbstractRoom
    {
        protected IRoomState State;

        public AbstractRoom(IRoomState initialState)
        {
            State = initialState;
        }

        // Template method - defines the overall flow
        public void Enter()
        {
            Console.WriteLine("\n== Entering Room ==");
            Describe();
            State.React();
            ShowActions();
        }

        protected abstract void Describe();  // Room-specific description
        protected abstract void ShowActions(); // Room-specific actions
    }
}
