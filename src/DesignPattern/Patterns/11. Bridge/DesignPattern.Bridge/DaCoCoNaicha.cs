using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class DaCoCoNaicha : CoCoNaicha
    {
        public DaCoCoNaicha()
        {
            Name += "+大杯";
            Price += 3;
        }
    }
}
