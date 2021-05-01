using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade
{
    public class AirConditioner
    {
        public void TurnOn()
        {
            Console.WriteLine("开空调...");
        }
        public void TurnOff()
        {
            Console.WriteLine("关空调...");
        }
    }
}
