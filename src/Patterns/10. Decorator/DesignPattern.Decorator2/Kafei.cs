using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator2
{
    public class Kafei : Drink
    {
        private string _desc = string.Empty;
        private int _cost = 0;
        public Kafei()
        {
            Name = "咖啡";
            Price = 12;
        }

        public override string Desc => this.Name + _desc;
        public override int Cost => this.Price + _cost;
        public override void AddBing()
        {
            _desc += "+糖";
        }

        public override void AddBuding()
        {

        }

        public override void AddHongdou()
        {

        }

        public override void AddTang()
        {
            _desc += "+冰";
        }

        public override void AddZhenzhu()
        {

        }

        public override void AddKafeibanlv()
        {
            _desc += "+咖啡伴侣";
            _cost += 2;
        }
    }
}
