using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPattern.Observer5
{
    public class Broker
    {
        private static readonly Lazy<Broker> _instance
            = new Lazy<Broker>(() => new Broker());

        private readonly Queue<EventData> _eventDatas = new Queue<EventData>();

        private readonly IList<IObserver> _observers = new List<IObserver>();

        private readonly Thread _thread;
        private Broker()
        {
            _thread = new Thread(Notify);
            _thread.Start();
        }

        public static Broker Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        private void Notify(object? state)
        {
            while (true)
            {
                if (_eventDatas.Count > 0)
                {
                   var eventData = _eventDatas.Dequeue();
                    foreach (var observer in _observers)
                    {
                        observer.Update(eventData);
                    }
                }

                Thread.Sleep(1000);
            }
        }

        public void Enqueue(EventData eventData)
        {
            _eventDatas.Enqueue(eventData);
        }
    }
}
