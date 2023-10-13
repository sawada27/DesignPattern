using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObserver
    {
        void Update(string message);
    }

    /// <summary>
    /// 观察者实现
    /// </summary>
    public class ConcreteObserver : IObserver
    {
        private string _observerState;
        private string _name;

        public ConcreteObserver(string name)
        {
            this._name = name;
        }

        public void Update(string message)
        {
            _observerState = message;
            Console.WriteLine($"Observer {_name} received the message: {_observerState}");
        }
    }


}
