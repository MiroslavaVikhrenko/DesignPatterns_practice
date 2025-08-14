using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Composite.Basic
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(string name, int x, int y, int radius) : base(name, x, y)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Circle: {Name} at ({X}, {Y}), radius: {Radius}");
        }
    }
}
