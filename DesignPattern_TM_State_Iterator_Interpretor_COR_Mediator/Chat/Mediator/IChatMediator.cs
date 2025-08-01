using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Chat.Mediator
{
    // Mediator pattern
    public interface IChatMediator
    {
        void Register(string name);
        void Broadcast(string message, string sender);
    }
}
