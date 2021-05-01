using System;

namespace DesignPrinciple.Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphics g = new Graphics();
            g.Stroke(ShapeType.Rectangle);
            g.Fill(ShapeType.Rectangle);
            g.Stroke(ShapeType.Circle);
            g.Fill(ShapeType.Circle);
        }
    }
}
