using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Composite.Basic
{
    public abstract class Shape : IGraphic
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        protected Shape(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }
        public abstract void Draw();

        public virtual void Move(int x, int y)
        {
            Console.WriteLine($"Moving {Name} from ({X}, {Y}) to ({X + x}, {Y + y})");
            X += x;
            Y += y;
        }
    }
}
