using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Composite.Basic
{
    public class Line : Shape
    {
        public int Length { get; set; }
        public Line(string name, int x, int y, int length) : base(name, x, y)
        {
            Length = length;
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing Line: {Name} at ({X}, {Y}), length: {Length}");
        }
    }
}
