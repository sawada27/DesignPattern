namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*模板方法模式  行为型模式

            使用场景：需要在运行时选择算法或策略。当有一组相似的算法，但它们的某些步骤可以变化，而其他步骤不变时。


            优点：
            代码重用：模板方法模式促进了代码重用，因为共享的算法部分位于基类中，而不同的实现部分在子类中。
            结构清晰：模板方法模式使算法的结构清晰可见，有助于维护和理解。
            扩展性：可以轻松添加新的咖啡种类，而无需修改现有的制作咖啡的算法框架。

            缺点：模板方法模式可能会限制子类的灵活性，因为子类必须遵循算法框架。
            随着算法的增加，基类可能会变得复杂，需要小心管理。

              速记：当有一组相似的算法，但它们的某些步骤可以变化，而其他步骤不变时。(类似局部重写)
            这种模式通常在软件框架和库中使用，以提供通用的算法框架，同时允许用户根据其需求进行自定义。

            可以运用到一些解除switch跟if else中
          */


            CoffeeTemplate americano = new AmericanoCoffee();
            americano.MakeCoffee();

            CoffeeTemplate latte = new LatteCoffee();
            latte.MakeCoffee();

            Console.ReadLine();
        }
    }
}