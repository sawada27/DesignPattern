using static Iterator.IteratorCode;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 迭代器模式    创建型模式
          使用场景： 系统需要访问一个聚合对象的内容而无需暴露它的内部表示。
                        系统需要支持对聚合对象的多种遍历。
                        该模式在.net中，可以通过实现IEnumberable接口即可，不再需要单独实现。

              优点：1.访问一个集合对象内部，而不需要暴露内部表示。
                     2.迭代器模式针对集合对象，都可以使用，重用性高。
              缺点：在遍历集合对象时，对对象集合进行修改会报错，但是有解决方案。(Copy新集合，打标记)

              速记:
       */


            Console.WriteLine("迭代器模式：");
            IListCollection list = new ConcreteList();
            var iterator = list.GetIterator();

            while (iterator.MoveNext())
            {
                int i = (int)iterator.GetCurrent();
                Console.WriteLine(i.ToString());
                iterator.Next();
            }
        }
    }
}