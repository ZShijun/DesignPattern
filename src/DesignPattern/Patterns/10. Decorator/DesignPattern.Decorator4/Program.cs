using System;

namespace DesignPattern.Decorator4
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink drink = new Naicha();
            drink = new Hongdou(drink);
            drink = new Bing(drink);
            drink = new Buding(drink);
            Console.WriteLine($"描述：{drink.Desc},价格:{drink.Cost}");

            Drink drink2 = new Kafei();
            drink2 = new Kafeibanlv(drink2);
            drink2 = new Tang(drink2);
            Console.WriteLine($"描述：{drink2.Desc},价格:{drink2.Cost}");
        }
    }
}
