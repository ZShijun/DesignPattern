using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("开灯...");
        }
        public void TurnOff()
        {
            Console.WriteLine("关灯...");
        }
    }
}
