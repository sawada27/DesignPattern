namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 原型模式  创造型模式

        场景： 当一个对象的创建比复制效率更高时，原型模式是一个不错的选择。
                当需要避免构造对象的成本，或者希望更灵活地创建对象副本时，可以使用原型模式。
                原型模式适用于需要创建具有相同属性的对象，但这些对象的状态可能不同。
    
         优点：
         减少对象创建开销： 原型模式允许通过复制现有对象来创建新对象，而不是从头开始创建，减少了对象创建的开销。
        更灵活的对象创建： 客户端可以动态克隆对象，根据需要创建对象的副本，而无需了解对象的具体构造过程。
        简化对象的初始化： 克隆对象时，不需要再次设置对象的初始属性，因为它们已经在原型对象上设置好。

        缺点:
        深拷贝复杂性： 如果对象包含了复杂的嵌套结构，实现深拷贝可能会很复杂。
        破坏封装性： 克隆方法可能需要访问对象的内部细节，这可能破坏对象的封装性。
        不适合所有情况： 原型模式并不适用于所有类型的对象，特别是那些具有大量共享状态的对象。

        速记：拷贝对象
            */



            Circle originalCircle = new Circle(10, "Red");

            Circle clonedCircle = (Circle)originalCircle.Clone();
            clonedCircle.Color = "Blue";

            Console.WriteLine("Original Circle: Radius = " + originalCircle.Radius + ", Color = " + originalCircle.Color);
            Console.WriteLine("Cloned Circle: Radius = " + clonedCircle.Radius + ", Color = " + clonedCircle.Color);


            Console.ReadLine();
        }
    }
}