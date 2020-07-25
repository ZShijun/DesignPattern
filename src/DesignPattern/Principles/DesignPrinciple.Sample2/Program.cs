using System;

namespace DesignPrinciple.Sample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphics g = new Graphics();
            g.StrokeRectangle();
            g.FillRectangle();
            g.StrokeCircle();
            g.FillCircle();
        }
    }
}
