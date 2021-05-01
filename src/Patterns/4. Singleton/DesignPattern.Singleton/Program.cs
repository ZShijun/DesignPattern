using System;

namespace DesignPattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int count1 = SingletonSample1.IncreaseCount();
            int count2 = SingletonSample1.IncreaseCount();
            Console.WriteLine($"count1={count1},count2={count2}");
        }
    }
}
