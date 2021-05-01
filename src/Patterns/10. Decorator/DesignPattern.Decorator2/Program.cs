using System;

namespace DesignPattern.Decorator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink drink = new Naicha();
            drink.AddBing();
            drink.AddHongdou();
            drink.AddZhenzhu();
            Console.WriteLine($"描述：{drink.Desc},价格:{drink.Cost}");

            Drink drink2 = new Kafei();
            drink2.AddKafeibanlv();
            Console.WriteLine($"描述：{drink2.Desc},价格:{drink2.Cost}");
        }
    }
}
