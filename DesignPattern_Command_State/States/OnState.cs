using DesignPattern_Command_State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Command_State.States
{
    public class OnState(Television tv) : ITVState
    {
        private readonly Television _tv = tv;

        public void ChangeChannel(int channel)
        {
            Console.WriteLine($"Changing channel to {channel}.");
            _tv.ChangeChannel(channel);
        }

        public void Mute()
        {
            Console.WriteLine("Muting the TV.");
            _tv.SetState(_tv.MutedState);
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off the TV.");
            _tv.SetState(_tv.OffState);
        }

        public void TurnOn()
        {
            Console.WriteLine("The TV is already on.");
        }

        public void IncreaseVolume()
        {
            _tv.Volume++;
            Console.WriteLine($"Volume increased to {_tv.Volume}");
        }

        public void DecreaseVolume()
        {
            _tv.Volume = Math.Max(0, _tv.Volume - 1);
            Console.WriteLine($"Volume decreased to {_tv.Volume}");
        }

        public void Unmute()
        {
            Console.WriteLine("TV is not muted.");
        }
    }

}
