using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        private IDrawer circle;
        private IDrawer square;

        public Facade()
        {
            circle = new CircleDrawer();
            square = new SquareDrawer();
        }

        public void DrawCircle()
        {
            circle.Draw();
        }

        public void DrawSquare()
        {
            square.Draw();
        }
    }
}
