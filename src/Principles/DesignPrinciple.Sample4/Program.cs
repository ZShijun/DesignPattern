using System;

namespace DesignPrinciple.Sample4
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphics g = new Graphics(new Rectangle());
            g.Stroke();
            g.Fill();
            g.SetShape(new Circle());
            g.Stroke();
            g.Fill();
        }
    }
}
