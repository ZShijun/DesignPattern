using DesignPattern.Bridge2.Brands;
using DesignPattern.Bridge2.Skus;
using System;

namespace DesignPattern.Bridge2
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandBase brand = new Ruixin();
            SkuBase sku = new Dabei();
            Drink drink = new Kafei(brand, sku);

            Console.WriteLine($"描述：{drink.Desc},价格:{drink.Cost}");
        }
    }
}
