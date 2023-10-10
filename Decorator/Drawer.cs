using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class CircleDrawer : IDrawer
    {
        void IDrawer.Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }

    public class SquareDrawer : IDrawer
    {
        void IDrawer.Draw()
        {
            Console.WriteLine("Draw Square");
        }
    }


}
