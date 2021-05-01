using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State3
{
    public abstract class TrafficLightState
    {
        public abstract void Handle(TrafficLight light);
    }
}
