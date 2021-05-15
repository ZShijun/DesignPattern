using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer5
{
    public class Wife : IObserver
    {
        public void Update(EventData eventData)
        {
            if (eventData.EventType == "DogBark")
            {
                Wakeup();
            }
        }

        public void Wakeup()
        {
            Console.WriteLine("便有妇人惊觉欠伸");
        }
    }
}
