using System;

namespace DesignPattern.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Naicha xicha = new DaXichaNaicha();
            Console.WriteLine($"描述：{xicha.Desc},价格:{xicha.Cost}");
            Naicha coco = new ZhongCoCoNaicha();
            Console.WriteLine($"描述：{coco.Desc},价格:{coco.Cost}");
        }
    }
}
