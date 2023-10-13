using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface ISubject
    {

        /// <summary>
        /// 注册观察者
        /// </summary>
        /// <param name="observer"></param>
        void RegisterObserver(IObserver observer);

        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="observer"></param>

        void RemoveObserver(IObserver observer);

        /// <summary>
        /// 通知观察者
        /// </summary>
        void NotifyObservers();
    }

    /// <summary>
    /// 主题实现
    /// </summary>
    public class ConcreteSubject : ISubject
    {
        //维护观察者列表
        private List<IObserver> observers = new List<IObserver>();
        private string _state;


        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                //主动通知变化
                NotifyObservers();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(State);
            }
        }
    }
}
