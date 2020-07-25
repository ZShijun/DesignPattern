using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciple.Sample5
{
    public class Graphics
    {
        public virtual void Stroke(Shape shape)
        {
            string path = shape.GetPath();
            Console.WriteLine($"描边{path}");
        }

        public virtual void Fill(Shape shape)
        {
            string path = shape.GetPath();
            Console.WriteLine($"填充{path}");
        }
    }
}
