using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator3
{
    public abstract class Drink
    {
        protected List<Peiliao> Peiliaos = new List<Peiliao>();
        public string Name { get; set; }

        public int Price { get; set; }

        public int Cost
        {
            get
            {
                int cost = this.Price;
                foreach (var peiliao in Peiliaos)
                {
                    cost += peiliao.Price;
                }
                return cost;
            }
        }

        public string Desc
        {
            get
            {
                string desc = this.Name;
                foreach (var peiliao in Peiliaos)
                {
                    desc += "+" + peiliao.Name;
                }
                return desc;
            }
        }

        public void AddPeiliao(Peiliao peiliao)
        {
            Peiliaos.Add(peiliao);
        }
    }
}