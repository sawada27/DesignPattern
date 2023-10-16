using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Shape
    {
        public string Color { get; set; }

        public abstract Shape Clone();
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        public override Shape Clone()
        {
            // 实现深拷贝
            return new Circle(this.Radius, this.Color);
        }
    }
}
