using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator4
{
    public class Tang : Peiliao
    {
        public Tang(Drink drink) : base(drink)
        {
            Name = "糖";
            Price = 0;
        }
    }
}
