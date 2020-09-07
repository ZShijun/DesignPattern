using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    public class Graphics
    {
        public void Stroke(ToolEnum tool)
        {
            switch (tool)
            {
                case ToolEnum.Pen:
                    Console.WriteLine($"用钢笔描边图形");
                    break;
                case ToolEnum.Brush:
                    Console.WriteLine($"用笔刷描边图形");
                    break;
                case ToolEnum.Bucket:
                    Console.WriteLine("油漆桶不能描边图形");
                    break;
                default:
                    throw new NotSupportedException("不支持的画图工具");
            }
        }
        
        public void Fill(ToolEnum tool)
        {
            switch (tool)
            {
                case ToolEnum.Pen:
                    Console.WriteLine($"钢笔不能填充图形");
                    break;
                case ToolEnum.Brush:
                    Console.WriteLine($"用笔刷填充图形");
                    break;
                case ToolEnum.Bucket:
                    Console.WriteLine("用油漆桶填充图形");
                    break;
                default:
                    throw new NotSupportedException("不支持的画图工具");
            }
        }
    }
}
