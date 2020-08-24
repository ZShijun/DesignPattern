using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator4
{
    public abstract class Drink
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public abstract string Desc { get; }

        public abstract int Cost { get; }
    }
}
