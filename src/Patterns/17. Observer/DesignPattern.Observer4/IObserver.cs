using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer4
{
    public interface IObserver
    {
        void Update(EventData eventData);
    }
}
