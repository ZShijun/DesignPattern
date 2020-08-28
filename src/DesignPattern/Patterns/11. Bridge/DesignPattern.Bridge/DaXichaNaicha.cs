using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class DaXichaNaicha : XichaNaicha
    {
        public DaXichaNaicha()
        {
            Name += "+大杯";
            Price += 3;
        }
    }
}
