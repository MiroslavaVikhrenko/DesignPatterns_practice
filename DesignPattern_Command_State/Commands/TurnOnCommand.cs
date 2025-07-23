using DesignPattern_Command_State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Command_State.Commands
{
    public class TurnOnCommand : ICommand
    {
        private readonly Television _tv;

        public TurnOnCommand(Television tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.CurrentState.TurnOn();
        }
    }
}
