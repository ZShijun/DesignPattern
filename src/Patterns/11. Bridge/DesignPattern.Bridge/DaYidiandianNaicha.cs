using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class DaYidiandianNaicha : YidiandianNaicha
    {
        public DaYidiandianNaicha()
        {
            Name += "+大杯";
            Price += 3;
        }
    }
}
