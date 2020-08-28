using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge2.Brands
{
    public abstract class BrandBase
    {
        public abstract string BrandName { get; }

        public abstract int Price { get; }
    }
}
