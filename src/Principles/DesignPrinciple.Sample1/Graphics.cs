using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciple.Sample1
{
    public class Graphics
    {
        public void Stroke(ShapeType shape)
        {
            if (shape == ShapeType.Rectangle)
            {
                Rectangle rectangle = new Rectangle();
                Console.WriteLine($"描边{rectangle.GetPath()}");
            }
            else if (shape == ShapeType.Circle)
            {
                Circle circle = new Circle();
                Console.WriteLine($"描边{circle.GetPath()}");
            }
            else
            {
                Console.WriteLine("不会画");
            }
        }

        public void Fill(ShapeType shape)
        {
            if (shape == ShapeType.Rectangle)
            {
                Rectangle rectangle = new Rectangle();
                Console.WriteLine($"填充{rectangle.GetPath()}");
            }
            else if (shape == ShapeType.Circle)
            {
                Circle circle = new Circle();
                Console.WriteLine($"填充{circle.GetPath()}");
            }
            else
            {
                Console.WriteLine("不会画");
            }
        }
    }
}