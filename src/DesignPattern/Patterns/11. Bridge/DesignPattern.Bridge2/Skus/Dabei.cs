using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge2.Skus
{
    public class Dabei : SkuBase
    {
        public override string SkuType => "大杯";

        public override int Price => 3;
    }
}
