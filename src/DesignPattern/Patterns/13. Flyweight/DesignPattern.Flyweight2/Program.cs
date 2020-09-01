using System;

namespace DesignPattern.Flyweight2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Typeface h = new HTypeface();
            //Typeface e = new ETypeface();
            //Typeface l = new LTypeface();
            //Typeface o = new OTypeface();

            Console.WriteLine($"{HTypeface.Instance.Print()}" +
                $"{ETypeface.Instance.Print()}{LTypeface.Instance.Print()}" +
                $"{LTypeface.Instance.Print()}{OTypeface.Instance.Print()}");
        }
    }
}
