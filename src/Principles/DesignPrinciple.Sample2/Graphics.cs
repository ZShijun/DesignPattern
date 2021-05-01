using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciple.Sample2
{
    public class Graphics
    {
        private readonly Rectangle _rectangle = new Rectangle();
        private readonly Circle _circle = new Circle();

        public void StrokeRectangle()
        {
            Console.WriteLine($"描边{_rectangle.GetPath()}");
        }

        public void FillRectangle()
        {
            Console.WriteLine($"填充{_rectangle.GetPath()}");
        }

        public void StrokeCircle()
        {
            Console.WriteLine($"描边{_circle.GetPath()}");
        }

        public void FillCircle()
        {
            Console.WriteLine($"填充{_circle.GetPath()}");
        }
    }
}
