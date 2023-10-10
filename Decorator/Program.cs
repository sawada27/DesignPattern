using System.Drawing;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 装饰器模式    结构型模式
             使用场景： 1、扩展一个类的功能。 2、动态增加功能，动态撤销。
             优点：装饰类和被装饰类可以独立发展，不会相互耦合，装饰模式是继承的一个替代模式，装饰模式可以动态扩展一个实现类的功能。
             缺点：多层装饰比较复杂。增加了类的数量，容易出现过多装饰器。

            速记:新旧对接
             */

            IDrawer drawer = new CircleDrawer();

            Decorator redCircle = new RedBorderDecorator(new CircleDrawer());
            Decorator redSquare = new RedBorderDecorator(new SquareDrawer());


            //默认画 原功能使用
            drawer.Draw();


            //保持原功能基础上添加额外功能
            redCircle.Draw();

            //保持原功能基础上添加额外功能
            redSquare.Draw();

        }
    }
}