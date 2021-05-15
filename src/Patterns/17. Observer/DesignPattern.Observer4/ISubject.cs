using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer4
{
    public interface ISubject
    {
        void AddObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void Publish(EventData eventData);
    }
}
