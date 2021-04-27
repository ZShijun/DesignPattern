using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State1
{
    public class YellowLightShineStrategy : IShineStrategy
    {
        public void Shine()
        {
            Console.WriteLine("黄灯亮了等一等");
        }
    }
}
