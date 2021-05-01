using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator4
{
    public class Hongdou : Peiliao
    {
        public Hongdou(Drink drink) : base(drink)
        {
            Name = "红豆";
            Price = 1;
        }
    }
}
