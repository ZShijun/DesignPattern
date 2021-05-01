using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder2
{
    public class LowScreenBuilder : ScreenBuilder
    {
        public override Screen BuildScreen()
        {
            return new LowScreen();
        }
    }
}
