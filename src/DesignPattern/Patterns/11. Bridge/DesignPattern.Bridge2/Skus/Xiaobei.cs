using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge2.Skus
{
    public class Xiaobei : SkuBase
    {
        public override string SkuType => "小杯";

        public override int Price => 1;
    }
}
