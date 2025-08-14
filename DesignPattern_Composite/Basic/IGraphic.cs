using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Composite.Basic
{
    public interface IGraphic
    {
        void Draw();
        void Move(int x, int y);
    }
}
