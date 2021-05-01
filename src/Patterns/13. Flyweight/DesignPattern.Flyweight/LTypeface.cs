using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight
{
    public class LTypeface : Typeface
    {
        public override string Print()
        {
            return "L";
        }
    }
}
