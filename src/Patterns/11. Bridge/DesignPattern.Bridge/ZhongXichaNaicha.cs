using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class ZhongXichaNaicha : XichaNaicha
    {
        public ZhongXichaNaicha()
        {
            Name += "+中杯";
            Price += 2;
        }
    }
}
