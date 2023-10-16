namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*状态模式  行为性模式

             使用场景：行为随状态改变而改变。
            状态已确定，且状态不宜过多。
            游戏开发中常用
            重构if..else或switch..case的不二之选。

            优点：结构清晰,封装性好,只知行为。
            缺点：增加类的数量，在状态过多的情况下，会导致具体状态类的膨胀。

            速记：行为改变状态的方法
*/


            Car car = new Car() { Name = "问界M5" };
            car.Run(); //stop  => run
            car.SpeedUp();//  run =>  SpeedUp
            car.SpeedDown(); // SpeedUp => run or SpeedDown
            car.Stop();  // anyState =>  stop

            Console.ReadLine();



        }
    }
}