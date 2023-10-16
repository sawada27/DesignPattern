using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 装饰器
    /// </summary>
    public abstract class Decorator : IDrawer
    {
        protected IDrawer _decorated;

        public Decorator(IDrawer decorated)
        {
            _decorated = decorated;
        }

        public virtual void Draw()
        {
            _decorated.Draw();
        }
    }

    public class RedBorderDecorator : Decorator
    {


        public RedBorderDecorator(IDrawer decorated) : base(decorated)
        {
            _decorated = decorated;
        }


        public override void Draw()
        {
            base.Draw();
            //增加别的功能 装饰
            SetRedBorder();
        }

        private void SetRedBorder()
        {
            Console.WriteLine("Set red border");
        }
    }

}
