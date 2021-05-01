using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State1
{
    public class RedLightTurnStrategy : ITurnStrategy
    {
        public void Turn()
        {
            Console.WriteLine("红灯停");
        }
    }
}
