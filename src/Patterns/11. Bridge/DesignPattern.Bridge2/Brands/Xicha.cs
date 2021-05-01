using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge2.Brands
{
    public class Xicha : BrandBase
    {
        public override string BrandName => "[喜茶]";

        public override int Price => 3;
    }
}
