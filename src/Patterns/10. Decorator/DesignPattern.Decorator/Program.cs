using System;

namespace DesignPattern.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink drink = new JiaTangJiaBingZhenzhuNaicha();
            Console.WriteLine($"描述：{drink.Desc},价格:{drink.Cost}");
        }
    }
}
