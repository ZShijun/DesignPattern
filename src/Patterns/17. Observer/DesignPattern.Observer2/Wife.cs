using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer2
{
    public class Wife : IObserver
    {
        public void Update()
        {
            Wakeup();
        }

        public void Wakeup()
        {
            Console.WriteLine("便有妇人惊觉欠伸");
        }
    }
}
