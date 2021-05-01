using System;

namespace DesignPattern.State2
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight light = new TrafficLight();
            light.Turn();
            light.SetState(new GreenState());
            light.Turn();
            light.SetState(new YellowState());
            light.Turn();
            light.Turn();
        }
    }
}
