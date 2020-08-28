using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge2.Brands
{
    public class CoCo : BrandBase
    {
        public override string BrandName => "[CoCo]";

        public override int Price => 2;
    }
}
