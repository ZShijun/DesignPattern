using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator4
{
    public class Kafei : Drink
    {
        public Kafei()
        {
            Name = "咖啡";
            Price = 12;
        }
        public override string Desc => this.Name;
        public override int Cost => this.Price;
    }
}
