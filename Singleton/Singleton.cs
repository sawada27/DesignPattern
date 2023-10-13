using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{

    /// <summary>
    /// 泛型单例模式的实现
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingletonInstance<T> where T : class 
    {
        private static T instance;

        private static readonly object Locker = new object();

        public static T GetInstance()
        {
            //没有第一重 instance == null 的话，每一次有线程进入 GetInstance()时，均会执行锁定操作来实现线程同步，
            //非常耗费性能 增加第一重instance ==null 成立时的情况下执行一次锁定以实现线程同步
            if (instance == null)
            {
                //Double-Check Locking 双重检查锁定
                lock (Locker)
                {
                    if (instance == null)
                    {
                        //第二个参数防止异常 如果该对象没有定义无参数的构造函数。
                        instance = Activator.CreateInstance(typeof(T), true) as T;
                    }
                }
            }
            return instance;
        }

        public void GetInfo()
        {
            Console.WriteLine($"I am {GetType().Name}.");
        }
    }


    public class Test
    {

        public string Name { get; set; }


         public void GetInfo()
        {
            Console.WriteLine($"I am {GetType().Name}.HashCode is {this.GetHashCode()}");
        }
    }


    /// <summary>
    /// 通过继承泛型单例来获取实例
    /// </summary>
    public class Singleton4
    {
        /// <summary>
        /// 非公共无参构造函数，确保该类无法在其他地方实例化
        /// </summary>
        private Singleton4()
        {

        }

        /// <summary>
        /// 也可以通过暴露属性获取实例
        /// </summary>
        public static Singleton4 Instance
        {
            get
            {
                return SingletonInstance<Singleton4>.GetInstance();
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"I am {this.GetType().Name}.");
        }

    }



}
