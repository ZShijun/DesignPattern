using DesignPattern.Bridge2.Brands;
using DesignPattern.Bridge2.Skus;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge2
{
    public class Kafei : Drink
    {
        public Kafei(BrandBase brand, SkuBase sku) : base(brand, sku)
        {
            Name = "咖啡";
            Price = 12;
        }
    }
}
