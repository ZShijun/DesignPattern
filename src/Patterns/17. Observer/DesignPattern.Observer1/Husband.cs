using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer1
{
    public class Husband: IObserver
    {
        public void DreamTalk()
        {
            Console.WriteLine("其夫呓语");
        }

        public void Update()
        {
            DreamTalk();
        }
    }
}
