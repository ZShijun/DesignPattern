using System;

namespace DesignPattern.State1
{
    class Program
    {
        static void Main(string[] args)
        { 
            TrafficLight light = new TrafficLight();
            light.ChangeShineStrategy(new RedLightShineStrategy());
            light.Shine();
            light.ChangeShineStrategy(new GreenLightShineStrategy());
            light.Shine();
            light.ChangeShineStrategy(new YellowLightShineStrategy());
            light.Shine();
        }
    }
}
