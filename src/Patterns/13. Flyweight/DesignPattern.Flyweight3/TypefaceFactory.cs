using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight3
{
    public class TypefaceFactory
    {
        private static readonly Typeface _h = new HTypeface();
        private static readonly Typeface _e = new ETypeface();
        private static readonly Typeface _l = new LTypeface();
        private static readonly Typeface _o = new OTypeface();

        public static Typeface H => _h;
        public static Typeface E => _e;
        public static Typeface L => _l;
        public static Typeface O => _o;
    }
}
