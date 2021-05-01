using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge2.Skus
{
    public abstract class SkuBase
    {
        public abstract string SkuType { get; }

        public abstract int Price { get; }
    }
}
