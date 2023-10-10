namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 外观模式   结构型模式
             
             使用场景： 1、为复杂的模块或子系统提供外界访问的模块。 2、子系统相对独立。 3、预防低水平人员带来的风险。
             优点： 1、减少系统相互依赖。 2、提高灵活性。 3、提高了安全性。
             缺点：不符合开闭原则，如果要改东西很麻烦，继承重写都不合适。不适合需要细粒度控制的情况。

            速记:简化复杂系统，提供统一接口。
             */

            Facade facade = new Facade();

            facade.DrawCircle();
            facade.DrawSquare();
          

        }
    }
}