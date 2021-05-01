using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge2.Brands
{
    public class Yidiandian : BrandBase
    {
        public override string BrandName => "[一点点]";

        public override int Price => 2;
    }
}
