using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class CoCoNaicha:Naicha
    {
        public CoCoNaicha()
        {
            Name += "[CoCo]";
            Price += 2;
        }
    }
}
