using DesignPattern_Command_State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Command_State.Commands
{
    public class DecreaseVolumeCommand : ICommand
    {
        private readonly Television _tv;

        public DecreaseVolumeCommand(Television tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.CurrentState.DecreaseVolume();
        }
    }
}
