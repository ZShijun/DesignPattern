using System;

namespace DesignPrinciple.Sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphics g = new Pen();
            g.Stroke(new Circle());
            g.Fill(new Circle());

            g = new Brush();
            g.Stroke(new Circle());
            g.Fill(new Circle());

            g = new Bucket();
            g.Stroke(new Circle());
            g.Fill(new Circle());
        }
    }
}
