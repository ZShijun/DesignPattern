using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer3
{
    public class Husband : IObserver
    {
        public void DreamTalk()
        {
            Console.WriteLine("其夫呓语");
        }

        public void Update(EventData eventData)
        {
            if (eventData.EventType == "DogBark")
            {
                DreamTalk();
            }
            else if (eventData.EventType == "SonCry")
            {
                Wakeup();
            }
        }

        public void Wakeup()
        {
            Console.WriteLine("夫亦醒");
        }
    }
}
