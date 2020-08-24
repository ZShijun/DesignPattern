using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator4
{
    public class Bing : Peiliao
    {
        public Bing(Drink drink) : base(drink)
        {
            Name = "冰";
            Price = 0;
        }
    }
}
