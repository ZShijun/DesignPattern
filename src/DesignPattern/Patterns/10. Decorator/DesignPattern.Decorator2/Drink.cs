using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator2
{
    public abstract class Drink
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public abstract string Desc { get; }

        public abstract int Cost { get; }

        public abstract void AddBuding();

        public abstract void AddHongdou();

        public abstract void AddZhenzhu();

        public abstract void AddBing();

        public abstract void AddTang();

        public abstract void AddKafeibanlv();
    }
}
