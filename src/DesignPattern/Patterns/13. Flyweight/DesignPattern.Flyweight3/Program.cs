using System;

namespace DesignPattern.Flyweight3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"{TypefaceFactory.H.Print()}" +
               $"{TypefaceFactory.E.Print()}{TypefaceFactory.L.Print()}" +
               $"{TypefaceFactory.L.Print()}{TypefaceFactory.O.Print()}");
        }
    }
}
