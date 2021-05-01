using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge2.Skus
{
    public class Zhongbei : SkuBase
    {
        public override string SkuType => "中杯";

        public override int Price => 2;
    }
}
