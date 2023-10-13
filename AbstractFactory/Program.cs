using static AbstractFactory.AbstractFactory;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*抽象工厂模式  创建型模式

             抽象工厂是应对产品族概念的，比如说，每个汽车公司可能要同时生产轿车，货车，客车，那么每一个工厂都要有创建轿车，货车和客车的方法。
                        使用场景: 一个系统不要求依赖产品类实例如何被创建、组合和表达的表达，这点也是所有工厂模式应用的前提。
                        这个系统有多个系列产品，而系统中只消费其中某一系列产品。
                         系统要求提供一个产品类的库，所有产品以同样的接口出现，客户端不需要依赖具体实现。

                     优点:应对产品族概念而生，增加新的产品线很容易。
                     缺点:增加新的产品改动很大。
             */
            Console.WriteLine("抽象工厂模式：");

            ///选择不同的工厂实现 宝马
            var bmwFactory = new BMWFactory();
            bmwFactory.CreateCar().GetInfo();
            bmwFactory.CreateBus().GetInfo();

            Console.WriteLine("BYD工厂");
            ///比亚迪
            var bydFactory = new BYDFactory();
            bydFactory.CreateCar().GetInfo();
            bydFactory.CreateBus().GetInfo();

            Console.ReadLine();

        }
    }
}