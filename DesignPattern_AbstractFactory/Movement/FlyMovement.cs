using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_AbstractFactory.Movement
{
    public class FlyMovement : IMovement
    {
        public string GetMovementType() => "Flying in the air";
    }
}
