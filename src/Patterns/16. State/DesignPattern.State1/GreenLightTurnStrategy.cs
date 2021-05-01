using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State1
{
    public class GreenLightTurnStrategy : ITurnStrategy
    {
        public void Turn()
        {
            Console.WriteLine("绿灯行");
        }
    }
}
