using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Mana { get; set; } = 100;
        public int CooldownTurns { get; set; } = 0;

        public Player(string name)
        {
            Name = name;
        }
    }
}
