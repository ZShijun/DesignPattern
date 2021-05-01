using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator4
{
    public class Kafeibanlv : Peiliao
    {
        public Kafeibanlv(Drink drink) : base(drink)
        {
            Name = "咖啡伴侣";
            Price = 1;
        }
    }
}
