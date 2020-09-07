using System;

namespace DesignPattern.Strategy3
{
    class Program
    {
        static void Main(string[] args)
        {
            IStrokeStrategy strokeStrategy = StrokeStrategyFactory.CreateStrokeStrategy(StrokeWith.Pen);
            IFillStrategy fillStrategy = FillStrategyFactory.CreateFillStrategy(FillWith.Bucket);

            Graphics graphics = new Graphics(strokeStrategy, fillStrategy);

            graphics.Stroke();
            graphics.Fill();

            graphics.SetStrokeStrategy(StrokeStrategyFactory.CreateStrokeStrategy(StrokeWith.Brush));
        }
    }
}
