namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 桥接模式   建造型模式  将抽象和实现解耦，使得两者可以独立地变化。
    使用场景：  不希望或不适用使用继承的场景
                接口或抽象类不稳定的场景
                重用性要求较高的场景
                解决多层继承


    优点：分离抽象和实现，扩展性强。
    缺点：增加类的数量，复杂性高。

    速记：抽象和实现分离，支持多维度变化。
*/
            Project webProject = new MVCProject("Web项目");
            Manager projectManager = new ProjectManager(webProject);
            Manager productManager = new ProductManger(webProject);

            //项目经理怎么做
            projectManager.ManageProject();
            //产品经理怎么做
            productManager.ManageProject();

            Console.ReadLine();


        }
    }
}