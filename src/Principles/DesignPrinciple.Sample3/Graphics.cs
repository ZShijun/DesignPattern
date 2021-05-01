using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciple.Sample3
{
    public class Graphics
    {
        public void Stroke(Shape shape)
        {
            string path = shape.GetPath();
            Console.WriteLine($"描边{path}");
        }

        public void Fill(Shape shape)
        {
            string path = shape.GetPath();
            Console.WriteLine($"填充{path}");
        }
    }
}
