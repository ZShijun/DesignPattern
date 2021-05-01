using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight2
{
    public class ETypeface : Typeface
    {
        private static readonly Typeface _instance = new ETypeface();

        private ETypeface() { }

        public static Typeface Instance => _instance;

        public override string Print()
        {
            return "E";
        }
    }
}
