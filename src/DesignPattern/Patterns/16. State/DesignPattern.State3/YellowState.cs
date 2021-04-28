using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPattern.State3
{
    public class YellowState : TrafficLightState
    {
        public override void Handle(TrafficLight light)
        {
            Console.WriteLine("黄灯亮了等一等");
            light.SetState(new RedState());
        }
    }
}
