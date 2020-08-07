using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder2
{
    public class HighScreenBuilder : ScreenBuilder
    {
        public override Screen BuildScreen()
        {
            return new HighScreen();
        }
    }
}
