using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public static class SimpleFactory
    {
        /// <summary>
        /// 普通工厂
        /// </summary>
        /// <param name="productType"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static AbstractCar Create(ProductEnum productType)
        {
            switch (productType)
            {
                case ProductEnum.ConcreateProductA:
                    return new ConcreateCarA();
                case ProductEnum.ConcreateProductB:
                    return new ConcreateCarB();
                default:
                    throw new ArgumentException();
            }
        }

        /// <summary>
        /// 反射实现 
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static AbstractCar Create(string typeName)
        {
            Type type = Type.GetType(typeName, true, true);
            var instance = Activator.CreateInstance(type) as AbstractCar;

            return instance;
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

    /// <summary>
    /// 巴士抽象
    /// </summary>
    public abstract class AbstractBus
    {
        protected abstract void DoOperation();

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.", this.GetType().Name));
        }
    }

    public class ConcreateBusA : AbstractBus
    {

        protected override void DoOperation()
        {

            throw new System.NotImplementedException();
        }
    }

    public class ConcreateBusB : AbstractBus
    {
        protected override void DoOperation()
        {
            throw new System.NotImplementedException();
        }
    }


    /// <summary>
    /// 产品枚举
    /// </summary>
    public enum ProductEnum
    {
        ConcreateProductA,

        ConcreateProductB
    }


}
