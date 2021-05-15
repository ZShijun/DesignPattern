using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer4
{
    public class Son : IObserver
    {
        private readonly ISubject _subject;
        public Son(ISubject subject)
        {
            this._subject = subject;
        }
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
            _subject.Publish(new EventData { Source = this, EventType = "SonCry" });
        }
    }
}
