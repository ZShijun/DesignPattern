using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy3
{
    public static class FillStrategyFactory
    {
        public static IFillStrategy CreateFillStrategy(FillWith fill) 
        {
            switch (fill)
            {
                case FillWith.Brush:
                    return new BrushFillStrategy();
                case FillWith.Bucket:
                    return new BucketFillStrategy();
                default:
                    throw new NotSupportedException("不支持的填充方式");
            }
        }
    }
}
