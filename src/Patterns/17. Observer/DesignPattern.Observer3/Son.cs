using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer3
{
    public class Son : Subject, IObserver
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
            Console.WriteLine("既而儿醒，大啼");
            Publish(new EventData { Source = this, EventType = "SonCry" });
        }
    }
}
