using System;

namespace DesignPattern.Decorator3
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink drink = new Naicha();
            drink.AddPeiliao(new Bing());
            drink.AddPeiliao(new Hongdou());
            drink.AddPeiliao(new Hongdou());
            drink.AddPeiliao(new Zhenzhu());
            Console.WriteLine($"描述：{drink.Desc},价格:{drink.Cost}");
            Drink drink2 = new Kafei();
            drink2.AddPeiliao(new Kafeibanlv());
            Console.WriteLine($"描述：{drink2.Desc},价格:{drink2.Cost}");
        }
    }
}
