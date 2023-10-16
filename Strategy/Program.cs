namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /*策略模式  行为性模式
             
        使用场景：需要在运行时选择算法或策略。
        优点：将算法和策略独立封装，支持动态切换。
        缺点：增加类的数量，客户端需要知道策略（破坏封装性）。

            速记：运行时 switch 选择策略 策略内部不同实现方法
        */

            IDeployer deployer = null;

            var applicationType = "Nebula";
            switch (applicationType)
            {
                case "Nebula":
                    Console.WriteLine("天气糟糕");
                    deployer = new ServerDeployer();
                    break;
                case "Java":
                    Console.WriteLine("天气晴好");
                    deployer = new BlueKingDeployer();
                    break;
                case "":
                    throw new Exception("暂不支持的部署");
            }
            var task = new DeployTaskFromDI();
            _ = deployer.Deploy(task, "YT-UAT", new Uri("127.0.0.1"));

            Console.ReadLine();
        }
    }
}