using DesignPattern_Command_State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Command_State.Commands
{
    public class ChangeChannelCommand : ICommand
    {
        private readonly Television _tv;
        private readonly int _channel;

        public ChangeChannelCommand(Television tv, int channel)
        {
            _tv = tv;
            _channel = channel;
        }

        public void Execute()
        {
            _tv.CurrentState.ChangeChannel(_channel);
        }
    }
}
