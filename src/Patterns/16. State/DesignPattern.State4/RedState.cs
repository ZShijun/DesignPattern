using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPattern.State4
{
    public class RedState : TrafficLightState
    {
        public override void Handle(TrafficLight light)
        {
            Console.WriteLine("红灯停");
            light.SetState(LightStateFactory.GetLightState<GreenState>());
        }
    }
}
