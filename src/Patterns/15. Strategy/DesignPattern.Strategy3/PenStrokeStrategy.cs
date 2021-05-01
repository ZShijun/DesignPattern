using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy3
{
    public class PenStrokeStrategy : IStrokeStrategy
    {
        public void Stroke()
        {
            Console.WriteLine($"用钢笔描边图形");
        }
    }
}
