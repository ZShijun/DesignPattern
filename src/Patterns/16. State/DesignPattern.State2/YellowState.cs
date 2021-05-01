using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPattern.State2
{
    public class YellowState : TrafficLightState
    {
        public override void Handle()
        {
            Console.WriteLine("黄灯亮了等一等");
        }
    }
}
