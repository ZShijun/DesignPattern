using System;

namespace DesignPattern.State
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight light = new TrafficLight();
            light.ChangeColor(LightColor.Red);
            light.Shine();
            light.ChangeColor(LightColor.Green);
            light.Shine();
            light.ChangeColor(LightColor.Yellow);
            light.Shine();
        }
    }
}
