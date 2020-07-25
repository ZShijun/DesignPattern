using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciple.Sample5
{
    public class Bucket:Graphics
    {
        public override void Fill(Shape shape)
        {
            Console.Write("用油漆桶");
            base.Fill(shape);
        }

        public override void Stroke(Shape shape)
        {
            
        }
    }
}
