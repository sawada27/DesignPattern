namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 观察者模式   行为型模式 最常用发布订阅中间件都是这个类型
            
            场景： 当一个对象的状态改变需要通知其他对象并且你不知道有多少对象需要通知时。
                   当一个对象需要通知其他对象，但不关心其他对象是谁或是如何处理通知的。
                   当对象之间存在一对多的依赖关系，其中一个对象的改变会影响其他对象的行为。
                   当你希望一个对象能够通知其他对象，而又希望避免对象之间的紧密耦合。

            优点：松耦合：观察者模式实现了主题和观察者之间的松耦合关系，主题不需要知道观察者的细节，只需知道它们实现了共同的接口。
            支持广播通信：主题可以通知多个观察者，使得信息传递给多个对象变得容易。
            可扩展性：可以随时添加新的观察者，而不需要修改主题的代码。
            封装变化：观察者模式封装了主题状态的变化，使得可以更容易管理和维护。
             
            缺点:
            可能导致性能问题：如果观察者非常多，或者观察者的更新操作非常耗时，可能导致性能问题。
            可能导致循环引用：如果观察者之间互相引用，可能导致循环引用问题，需要小心处理。

            速记： 事件驱动 进阶发布订阅模式
             */

            //主题
            ConcreteSubject subject = new ConcreteSubject();


            //观察者
            ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
            ConcreteObserver observer2 = new ConcreteObserver("Observer 2");

            //注册
            subject.RegisterObserver(observer1);
            subject.RegisterObserver(observer2);

            subject.State = "主题更新";


        }
    }
}