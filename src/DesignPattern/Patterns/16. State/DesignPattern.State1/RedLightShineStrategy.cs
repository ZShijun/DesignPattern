using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State1
{
    public class RedLightShineStrategy : IShineStrategy
    {
        public void Shine()
        {
            Console.WriteLine("红灯停");
        }
    }
}
