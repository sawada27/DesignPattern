namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*   命令模式  行为型模式
            应用场景：当需要将请求发送者和接收者解耦时。
            当需要支持撤销操作。
            当需要将一组操作组合成更复杂的操作序列，或者需要支持命令队列。
            当希望记录操作日志以实现撤销和重做功能。

            优点:解耦：命令模式将请求发送者和接收者解耦，发送者不需要了解接收者的具体操作。
            可扩展性：你可以轻松添加新的命令和接收者，而无需修改现有代码。
            支持撤销：命令模式支持操作的撤销，因为每个命令对象都可以保存状态信息。
            命令队列：你可以将命令对象存储在队列中，以支持任务调度和日志记录。

            缺点：
            类膨胀：可能需要创建多个具体命令类，导致类的数量增加。
            复杂性：某些场景下，命令模式可能会引入不必要的复杂性。

            速记：类似委托 指令作为参数传递 指令等于一系列方法操作
            */



            Light light = new Light();
            ICommand lightOn = new LightOnCommand(light);
            ICommand lightOff = new LightOffCommand(light);

            RemoteControl remote = new RemoteControl();
            remote.SetCommand(lightOn);


            //开灯
            remote.PressButton();

            //关灯
            remote.SetCommand(lightOff);
            remote.PressButton(); 


        }
    }
}