using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class XiaoCoCoNaicha : CoCoNaicha
    {
        public XiaoCoCoNaicha()
        {
            Name += "+小杯";
            Price += 1;
        }
    }
}
