﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy2
{
    public class BrushFillStrategy : IFillStrategy
    {
        public void Fill()
        {
            Console.WriteLine($"用笔刷填充图形");
        }
    }
}
