using System;

namespace DesignPattern.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Typeface h = new HTypeface();
            Typeface e = new ETypeface();
            Typeface l = new LTypeface();
            Typeface o = new OTypeface();
            Typeface w = new WTypeface();
            Typeface r = new RTypeface();
            Typeface d = new DTypeface();

            Console.WriteLine($"{h.Print()}{e.Print()}{l.Print()}{l.Print()}{o.Print()} {w.Print()}{o.Print()}{r.Print()}{l.Print()}{d.Print()}");
        }
    }
}
