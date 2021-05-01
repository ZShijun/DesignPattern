using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight2
{
    public class OTypeface : Typeface
    {
        private static readonly Typeface _instance = new OTypeface();

        private OTypeface() { }

        public static Typeface Instance => _instance;
        public override string Print()
        {
            return "O";
        }
    }
}
