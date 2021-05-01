using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator4
{
    public class Peiliao:Drink
    {
        protected readonly Drink Drink;

        public Peiliao(Drink drink)
        {
            Drink = drink;
        }

        public override string Desc
        {
            get
            {
                return Drink.Desc + "+" + this.Name;
            }
        }

        public override int Cost
        {
            get
            {
                return Drink.Cost + this.Price;
            }
        }
    }
}
