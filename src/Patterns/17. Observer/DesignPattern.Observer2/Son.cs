using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer2
{
    public class Son : IObserver
    {
        private readonly IList<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Update()
        {
            Wakeup();
        }

        public void Wakeup()
        {
            Console.WriteLine("既而儿醒，大啼");
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
