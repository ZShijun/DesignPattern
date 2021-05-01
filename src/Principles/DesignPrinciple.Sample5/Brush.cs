using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciple.Sample5
{
    public class Brush : Graphics
    {
        public override void Stroke(Shape shape)
        {
            Console.Write("用笔刷");
            base.Stroke(shape);
        }

        public override void Fill(Shape shape)
        {
            Console.Write("用笔刷");
            base.Fill(shape);
        }
    }
}
