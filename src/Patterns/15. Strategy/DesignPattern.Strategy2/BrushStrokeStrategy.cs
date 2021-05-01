using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy2
{
    public class BrushStrokeStrategy : IStrokeStrategy
    {
        public void Stroke()
        {
            Console.WriteLine($"用笔刷描边图形");
        }
    }
}
