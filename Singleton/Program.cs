namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*单例模式 创建型模式
             场景：避免产生多个对象消耗过多的资源（特别是一个对象需要频繁的创建和销毁时）；
             提供一个全局访问点，常常被用来管理系统中共享的资源(作为一个Manager)。
             
            优点：保证全局唯一性，可延迟初始化。
            缺点：可能引发多线程竞争问题。

             */


            var test = SingletonInstance<Test>.GetInstance();

            var test2 = SingletonInstance<Test>.GetInstance();


            var test3 = SingletonInstance<Test>.GetInstance();


            test.GetInfo();

            test2.GetInfo();

            test3.GetInfo();



        }
    }
}