using DesignPattern.Bridge2.Brands;
using DesignPattern.Bridge2.Skus;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge2
{
    public class Naicha : Drink
    {
        public Naicha(BrandBase brand, SkuBase sku):base(brand,sku)
        {
            Name = "奶茶";
            Price = 8;
        }
    }
}
