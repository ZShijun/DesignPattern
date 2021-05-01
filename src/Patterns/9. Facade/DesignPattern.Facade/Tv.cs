using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade
{
    public class Tv
    {
        public void TurnOn()
        {
            Console.WriteLine("打开电视机...");
        }

        public void TurnOff()
        {
            Console.WriteLine("关闭电视机...");
        }
    }
}
