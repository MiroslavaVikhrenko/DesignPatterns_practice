using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Command_State.Interfaces
{
    public interface ITVState
    {
        void TurnOn();
        void TurnOff();
        void ChangeChannel(int channel);
        void IncreaseVolume();
        void DecreaseVolume();
        void Mute();
        void Unmute();
    }
}
