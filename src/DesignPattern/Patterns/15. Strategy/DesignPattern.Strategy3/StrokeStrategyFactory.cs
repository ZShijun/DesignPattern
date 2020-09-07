using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy3
{
    public static class StrokeStrategyFactory
    {
        public static IStrokeStrategy CreateStrokeStrategy(StrokeWith stroke)
        {
            switch (stroke)
            {
                case StrokeWith.Pen:
                    return new PenStrokeStrategy();
                case StrokeWith.Brush:
                    return new BrushStrokeStrategy();
                default:
                    throw new NotSupportedException("不支持的描边方式");
            }
        }
    }
}
