using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State1
{
    public class GreenLightShineStrategy : IShineStrategy
    {
        public void Shine()
        {
            Console.WriteLine("绿灯行");
        }
    }
}
