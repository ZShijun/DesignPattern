using System;

namespace DesignPattern.Strategy2
{
    class Program
    {
        static void Main(string[] args)
        {
            IStrokeStrategy strokeStrategy = new PenStrokeStrategy();
            IFillStrategy fillStrategy = new BrushFillStrategy();

            Graphics graphics = new Graphics(strokeStrategy, fillStrategy);
            
            graphics.Stroke();
            graphics.Fill();
        }
    }
}
