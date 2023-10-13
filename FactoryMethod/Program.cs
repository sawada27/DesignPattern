namespace FactoryMethod
{
    internal class Program
    {

        public interface IFactoryMethod
        {
            AbstractCar Create();
        }

        public class ConcreateFactoryA : IFactoryMethod
        {
            public AbstractCar Create()
            {
                return new ConcreateCarA();
            }
        }

        public class ConcreateFactoryB : IFactoryMethod
        {
            public AbstractCar Create()
            {
                return new ConcreateCarB();
            }
        }

        /// <summary>
        /// 车抽象
        /// </summary>
        public abstract class AbstractCar
        {
            protected abstract void DoOperation();

            public void GetInfo()
            {
                Console.WriteLine($"I am {GetType().Name}.");
            }
        }

        public class ConcreateCarA : AbstractCar
        {

            protected override void DoOperation()
            {

                throw new System.NotImplementedException();
            }
        }

        public class ConcreateCarB : AbstractCar
        {
            protected override void DoOperation()
            {
                throw new System.NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
            /* 工厂方法模式    创建型模式 
    使用场景： 1、工厂方法是针对每一种产品提供一个工厂类。通过不同的工厂实例来创建不同的产品实例。
        优点：在同一等级结构中，支持增加任意产品。
        缺点：随着产品类的增加，对应的工厂也会随之增多

    */
            Console.WriteLine("工厂方法模式：");
            IFactoryMethod factoryB = new ConcreateFactoryB();
            var productB = factoryB.Create();
            productB.GetInfo();

            Console.ReadLine();

        }
    }
}