using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class ZhongYidiandianNaicha : YidiandianNaicha
    {
        public ZhongYidiandianNaicha()
        {
            Name += "+中杯";
            Price += 2;
        }
    }
}
