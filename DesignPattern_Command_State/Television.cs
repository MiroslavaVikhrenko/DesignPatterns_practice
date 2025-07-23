using DesignPattern_Command_State.Interfaces;
using DesignPattern_Command_State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Command_State
{
    public class Television
    {
        public ITVState OffState { get; set; }
        public ITVState OnState { get; set; }
        public ITVState MutedState { get; set; }

        public ITVState CurrentState { get; set; }

        public int Channel { get; set; } = 1;
        public int Volume { get;set; } = 10;
        public int PreviousVolume { get; set; } = 10;

        public Television()
        {
            OffState = new OffState(this);
            OnState = new OnState(this);
            MutedState = new MutedState(this); 
            CurrentState = OffState;
        }

        public void SetState(ITVState newState)
        {
            CurrentState = newState;
        }
        public void ChangeChannel(int channel)
        {
            if (CurrentState == OnState)
            {
                Channel = channel;
                Console.WriteLine($"Channel changed to {Channel}");
            }
            else
            {
                Console.WriteLine("Cannot change channel. The TV is off.");
            }
        }
    }
}
