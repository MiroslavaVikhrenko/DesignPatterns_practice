using DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Game
{
    // Drives room interaction using the iterator
    public class GameEngine
    {
        public void Start()
        {
            var rooms = new List<AbstractRoom>
            {
                new ForestRoom(new CalmState()),
                new CaveRoom(new DangerousState())
            };

            var iterator = new RoomIterator(rooms);

            while (iterator.HasNext())
            {
                var room = iterator.Next();
                room.Enter();

                Console.WriteLine("Press Enter to continue to next room...");
                Console.ReadLine();
            }

            Console.WriteLine("End of your journey.");
        }
    }
}
