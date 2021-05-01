using DesignPattern.Bridge2.Brands;
using DesignPattern.Bridge2.Skus;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge2
{
    public abstract class Drink
    {
        private readonly BrandBase _brand;

        private readonly SkuBase _sku;
        public Drink(BrandBase brand, SkuBase sku)
        {
            this._brand = brand;
            this._sku = sku;
        }

        public string Name { get; set; }

        public int Price { get; set; }


        public string Desc
        {
            get
            {
                return this.Name + this._brand.BrandName + this._sku.SkuType;
            }
        }

        public int Cost
        {
            get
            {
                return this.Price + this._brand.Price + this._sku.Price;
            }
        }
    }
}
