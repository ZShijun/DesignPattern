using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class XiaoXichaNaicha : XichaNaicha
    {
        public XiaoXichaNaicha()
        {
            Name += "+小杯";
            Price += 1;
        }
    }
}
