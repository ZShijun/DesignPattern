using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator2
{
    public class Naicha : Drink
    {
        private string _desc = string.Empty;
        private int _cost = 0;
        public Naicha()
        {
            Name = "奶茶";
            Price = 8;
        }

        public override string Desc => this.Name + _desc;
        public override int Cost => this.Price + _cost;

        public override void AddBing()
        {
            _desc += "+冰";
        }

        public override void AddBuding()
        {
            _desc += "+布丁";
            _cost += 2;
        }

        public override void AddHongdou()
        {
            _desc += "+红豆";
            _cost += 1;
        }

        public override void AddKafeibanlv()
        {

        }

        public override void AddTang()
        {
            _desc += "+糖";
        }

        public override void AddZhenzhu()
        {
            _desc += "+珍珠";
            _cost += 3;
        }
    }
}
