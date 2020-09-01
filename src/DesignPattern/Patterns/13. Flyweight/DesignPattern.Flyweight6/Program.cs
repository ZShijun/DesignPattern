using System;

namespace DesignPattern.Flyweight6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TypefaceFactory.SetTypeface("hello", new WordTypeface("Hello"));

            Console.WriteLine(TypefaceFactory.GetTypeface("hello").Print());
        }
    }
}
