using DesignPattern_Command_State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Command_State.States
{
    public class OffState(Television tv) : ITVState
    {
        private readonly Television _tv = tv;
        public void ChangeChannel(int channel)
        {
            Console.WriteLine("The TV is off. Please turn it on to change the channel.");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine("The TV is off. Please turn it on to change the volume.");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("The TV is off. Please turn it on to change the volume.");
        }

        public void Mute()
        {
            Console.WriteLine("The TV is off. Please turn it on to mute.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The TV is already turned off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("The TV is truned on.");
            _tv.SetState(_tv.OnState);
        }

        public void Unmute()
        {
            Console.WriteLine("The TV is off. Please turn it on to unmute.");
        }
    }
}
