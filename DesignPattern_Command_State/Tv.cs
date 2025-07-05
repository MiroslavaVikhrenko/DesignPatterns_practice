using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Command_State
{
    public class Tv
    {
        public int Volume { get; set; } = 10;
        public int Channel { get; set; } = 1;
        public bool IsOn { get; set; } = false;
        public bool IsMuted { get; set; } = false;
        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("TV is ON");
        }
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("TV is OFF");
        }
    }
}
