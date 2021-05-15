using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer5
{
    public interface ISubject
    {
        void Publish(EventData eventData);
    }
}
