using System;

namespace DesignPattern.State2
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight light = new TrafficLight();
            light.SetState(new RedState());
            light.Shine();
            light.Shine();
            light.Shine();
            light.Shine();
            light.Shine();
        }
    }
}
