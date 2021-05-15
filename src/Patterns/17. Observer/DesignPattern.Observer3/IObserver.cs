using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer3
{
    public interface IObserver
    {
        void Update(EventData eventData);
    }
}
