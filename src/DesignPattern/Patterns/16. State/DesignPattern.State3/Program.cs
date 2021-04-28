using System;

namespace DesignPattern.State3
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight light = new TrafficLight();
            light.Turn();
            light.Turn();
            light.Turn();
            light.Turn();
        }
    }
}
