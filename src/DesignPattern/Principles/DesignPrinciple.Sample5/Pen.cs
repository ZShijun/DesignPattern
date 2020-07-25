using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciple.Sample5
{
    public class Pen : Graphics
    {
        public override void Stroke(Shape shape)
        {
            Console.Write("用钢笔");
            base.Stroke(shape);
        }

        public override void Fill(Shape shape)
        {

        }
    }
}
