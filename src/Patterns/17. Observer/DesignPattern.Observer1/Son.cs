using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer1
{
    public class Son : IObserver
    {
        public void Update()
        {
            Wakeup();
        }

        public void Wakeup()
        {
            Console.WriteLine("既而儿醒，大啼");
        }
    }
}
