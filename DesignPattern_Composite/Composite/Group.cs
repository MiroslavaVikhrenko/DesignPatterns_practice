using DesignPattern_Composite.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Composite.Composite
{
    public class Group : IGraphic
    {
        private List<IGraphic> _graphics = new List<IGraphic>();
        public string Name { get; set; }

        public Group(string name)
        {
            Name = name;
        }
        public void Add(IGraphic graphic)
        {
            _graphics.Add(graphic);
        }
        public void Remove(IGraphic graphic)
        {
            _graphics.Remove(graphic);
        }
        public void Draw()
        {
            Console.WriteLine($"Drawing Group: {Name}");
            foreach (var graphic in _graphics)
            {
                graphic.Draw();
            }
        }
        public void Move(int x, int y)
        {
            Console.WriteLine($"Moving Group: {Name} to ({x}, {y})");
            foreach (var graphic in _graphics)
            {
                graphic.Move(x, y);
            }
        }
    }
}
