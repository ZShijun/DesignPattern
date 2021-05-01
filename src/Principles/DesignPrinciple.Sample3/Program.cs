using System;

namespace DesignPrinciple.Sample3
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphics g = new Graphics();
            g.Stroke(new Rectangle());
            g.Fill(new Rectangle());

            g.Stroke(new Circle());
            g.Fill(new Circle());
        }
    }
}
