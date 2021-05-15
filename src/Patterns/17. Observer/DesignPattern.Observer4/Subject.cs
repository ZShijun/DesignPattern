using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Observer4
{
    public class Subject: ISubject
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

        public void Publish(EventData eventData)
        {
            foreach (var observer in _observers)
            {
                observer.Update(eventData);
            }
        }
    }
}
