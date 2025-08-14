using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Composite.Basic
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(string name, int x, int y, int width, int height) : base(name, x, y)
        {
            Width = width;
            Height = height;
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing Rectangle: {Name} at ({X}, {Y}), width: {Width}, height: {Height}");
        }
    }
}
