using DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Game
{
    // Iterator Pattern: provides controlled access to a sequence of rooms
    public class RoomIterator
    {
        private readonly List<AbstractRoom> _rooms;
        private int _current = 0;

        public RoomIterator(List<AbstractRoom> rooms)
        {
            _rooms = rooms;
        }

        public bool HasNext()
        {
            return _current < _rooms.Count;
        }

        public AbstractRoom Next()
        {
            return _rooms[_current++];
        }
    }
}
