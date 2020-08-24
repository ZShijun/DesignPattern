using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator4
{
    public class Zhenzhu : Peiliao
    {
        public Zhenzhu(Drink drink) : base(drink)
        {
            Name = "珍珠";
            Price = 3;
        }
    }
}
