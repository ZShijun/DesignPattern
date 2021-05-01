using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator4
{
    public class Naicha : Drink
    {
        public Naicha()
        {
            Name = "奶茶";
            Price = 8;
        }
        public override string Desc => this.Name;
        public override int Cost => this.Price;
    }
}
