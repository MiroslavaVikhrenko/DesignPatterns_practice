using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_AbstractFactory.Movement
{
    public class DriveMovement : IMovement
    {
        public string GetMovementType() => "Driving on land";
    }
}
