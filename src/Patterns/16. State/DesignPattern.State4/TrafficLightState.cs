using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State4
{
    public abstract class TrafficLightState
    {
        public abstract void Handle(TrafficLight light);
    }
}
