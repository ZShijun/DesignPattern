using System;

namespace DesignPattern.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphics graphics = new Graphics();
            graphics.Stroke(ToolEnum.Brush);

            graphics.Fill(ToolEnum.Bucket);

            graphics.Fill(ToolEnum.Pen);
        }
    }
}
