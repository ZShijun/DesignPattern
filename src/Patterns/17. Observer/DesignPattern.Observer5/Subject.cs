using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Observer5
{
    public class Subject: ISubject
    {
        public void Publish(EventData eventData)
        {
            Broker.Instance.Enqueue(eventData);
        }
    }
}
