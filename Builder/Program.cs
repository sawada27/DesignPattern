using System.IO;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 建造者模式   建造型模式
                使用场景：创建复杂对象，需要一步一步构建。 多个部件或者零件，都可以装配到一个对象中，但是产生的运行结果又相同。
                产品类非常复杂，或者产品类中调用顺序不同产生了不同的作用。
               

                优点：分离构建过程，更灵活，可组装不同配置。
                缺点：增加了对象构建的复杂性。

                速记： 初始化一个对象特别复杂，如使用多个构造方法，或者说有很多参数，并且都有默认值时。可以集中在Build方法中创建对象 
            */

            //指挥者 通过传入建造者
            Director director = new Director();

            //建造者
            HpBulider hpBuilder = new HpBulider();
            DellBulider dellBuilder = new DellBulider();

            //组装一批惠普电脑
            Computer hp = director.Construct(hpBuilder);
            hp.ShowSteps();

            Console.WriteLine();
            Console.ReadLine();

            //组装一批戴尔电脑
            Computer dell = director.Construct(dellBuilder);
            dell.ShowSteps();

            Console.ReadLine();
        }
    }
}