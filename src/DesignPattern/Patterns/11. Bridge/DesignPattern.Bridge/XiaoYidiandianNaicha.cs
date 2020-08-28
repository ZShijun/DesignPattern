using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class XiaoYidiandianNaicha : YidiandianNaicha
    {
        public XiaoYidiandianNaicha()
        {
            Name += "+小杯";
            Price += 1;
        }
    }
}
