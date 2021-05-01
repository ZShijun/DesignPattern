using System;

namespace DesignPattern.State1
{
    class Program
    {
        static void Main(string[] args)
        { 
            TrafficLight light = new TrafficLight(new RedLightTurnStrategy());
            light.Turn();
            light.ChangeTurnStrategy(new GreenLightTurnStrategy());
            light.Turn();
            light.ChangeTurnStrategy(new YellowLightTurnStrategy());
            light.Turn();
            light.Turn();
        }
    }
}
