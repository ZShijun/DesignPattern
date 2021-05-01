using System;

namespace DesignPattern.Flyweight5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"{TypefaceFactory.GetTypeface<HTypeface>().Print()}" +
               $"{TypefaceFactory.GetTypeface<ETypeface>().Print()}{TypefaceFactory.GetTypeface<LTypeface>().Print()}" +
               $"{TypefaceFactory.GetTypeface<LTypeface>().Print()}{TypefaceFactory.GetTypeface<OTypeface>().Print()}");
        }
    }
}
