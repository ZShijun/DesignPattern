using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight2
{
    public class HTypeface : Typeface
    {
        private static readonly Typeface _instance = new HTypeface();

        private HTypeface() { }

        public static Typeface Instance => _instance;
        public override string Print()
        {
            return "H";
        }
    }
}
