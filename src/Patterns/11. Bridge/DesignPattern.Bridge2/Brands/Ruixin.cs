using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge2.Brands
{
    public class Ruixin : BrandBase
    {
        public override string BrandName => "[瑞辛]";

        public override int Price => 2;
    }
}
