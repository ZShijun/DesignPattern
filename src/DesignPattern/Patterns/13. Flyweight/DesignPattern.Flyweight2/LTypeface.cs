using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight2
{
    public class LTypeface : Typeface
    {
        private static readonly Typeface _instance = new LTypeface();

        private LTypeface() { }

        public static Typeface Instance => _instance;
        public override string Print()
        {
            return "L";
        }
    }
}
