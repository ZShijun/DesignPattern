using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator4
{
    public class Buding : Peiliao
    {
        public Buding(Drink drink) : base(drink)
        {
            Name = "布丁";
            Price = 2;
        }
    }
}
