using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Rooms
{
    // State pattern interface => interface for room states that modify room behavior dynamically
    public interface IRoomState
    {
        void React();
    }
}
