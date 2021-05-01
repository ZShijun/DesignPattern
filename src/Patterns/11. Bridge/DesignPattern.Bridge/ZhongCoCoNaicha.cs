using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class ZhongCoCoNaicha : CoCoNaicha
    {
        public ZhongCoCoNaicha()
        {
            Name += "+中杯";
            Price += 2;
        }
    }
}
