using DesignPattern_Command_State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Command_State.States
{
    public class MutedState : ITVState
    {
        private readonly Television _tv;

        public MutedState(Television tv)
        {
            _tv = tv;
        }

        public void ChangeChannel(int channel)
        {
            Console.WriteLine($"Channel changed to {channel} (muted).");
            _tv.ChangeChannel(channel);
        }

        public void DecreaseVolume()
        {
            _tv.Volume = Math.Max(0, _tv.Volume - 1);
            Console.WriteLine("Volume changed while muted (still no sound).");
        }

        public void IncreaseVolume()
        {
            _tv.Volume++;
            Console.WriteLine("Volume increased while muted (still no sound).");
        }

        public void Mute()
        {
            Console.WriteLine("TV is already muted.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off the TV.");
            _tv.SetState(_tv.OffState);
        }

        public void TurnOn()
        {
            Console.WriteLine("The TV is already on (muted).");
        }

        public void Unmute()
        {
            Console.WriteLine("Unmuting the TV.");
            _tv.SetState(_tv.OnState);
        }
    }
}
