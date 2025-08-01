using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Chat.Mediator
{
    public class BattleMediator : IChatMediator
    {
        private readonly List<string> _participants = new();

        public void Register(string name)
        {
            _participants.Add(name);
        }

        public void Broadcast(string message, string sender)
        {
            foreach (var p in _participants)
            {
                if (p != sender)
                {
                    Console.WriteLine($" {p} hears: {message}");
                }
            }
        }
    }
}
