using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State1
{
    public class YellowLightTurnStrategy : ITurnStrategy
    {
        public void Turn()
        {
            Console.WriteLine("黄灯亮了等一等");
        }
    }
}
