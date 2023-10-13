namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 工厂模式    创建型模式
                使用场景： 1、用来创建目标对象的类，将相似对象的创建工作统一到一个类来完成。
                    优点：装饰类和被装饰类可以独立发展，不会相互耦合，装饰模式是继承的一个替代模式，装饰模式可以动态扩展一个实现类的功能。
                    缺点：多层装饰比较复杂。增加了类的数量，容易出现过多装饰器。

                速记:新旧对接
             */

            Console.WriteLine("(简单)工厂模式：");
            var productA = SimpleFactory.Create(ProductEnum.ConcreateProductA);
            productA.GetInfo();
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("反射实现");
            //反射实现
            var productB = SimpleFactory.Create("ConcreateProductA");
            productB.GetInfo();
            Console.ReadLine();


            //抽象工厂 拆分项目
        }
    }
}