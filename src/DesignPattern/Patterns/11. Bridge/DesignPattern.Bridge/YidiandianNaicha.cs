using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class YidiandianNaicha : Naicha
    {
        public YidiandianNaicha()
        {
            Name += "[一点点]";
            Price += 2;
        }
    }
}
