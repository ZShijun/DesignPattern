using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight6
{
    public class WordTypeface : Typeface
    {
        private readonly string _word;

        public WordTypeface(string word)
        {
            this._word = word;
        }

        public override string Print()
        {
            return this._word;
        }
    }
}
