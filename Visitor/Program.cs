namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //访问者模式  行为型模式

            //封装一些作用于某种数据结构中的各元素的操作，它可以在不改变数据结构的前提下定义作用于这些元素的新的操作。 封装一些作用于某种数据结构的各元素的操作，它可以在不改变数据结构的前提下定义作用于这些元素的新的操作。

            //不同对象在不同状态下展现不同行为？

            // 优点
            // 1. 访问者模式符合单一职责原则、让程序具有优秀的扩展性、灵活性非常高
            // 2. 访问者模式可以对功能进行统一，可以做报表、UI、拦截器与过滤器，适用于数据结构相对稳定的系统

            //缺点
            //1. 具体元素对访问者公布细节，也就是说访问者关注了其他类的内部细节，这是迪米特法则所不建议的, 这样造成了具体元素变更比较困难
            //2. 违背了依赖倒转原则。访问者依赖的是具体元素，而不是抽象元素
            //3. 因此，如果一个系统有比较稳定的数据结构，又有经常变化的功能需求，那么访问者模式就是比较合适的.

            //案例看懂了 但是不太会用  感觉也不太实用  业务开发来看 变化很大的需求会导致维护困难
            Console.WriteLine("Hello, World!");

            //拓展在于 新的被操作元素 继承Element 新的访问者元素 加入Visitor抽象  不符合开闭
            Element elementA = new ElementA();
            Element elementB = new ElementB();
            ObjectStructure elements = new ObjectStructure();
            elements.Add(elementA);
            elements.Add(elementB);
            Visitor visitor = new ConcreteVisitor();
            elements.Accept(visitor);
            Console.ReadLine();
        }
    }
}