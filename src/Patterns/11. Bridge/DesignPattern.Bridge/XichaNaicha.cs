using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class XichaNaicha : Naicha
    {
        public XichaNaicha()
        {
            Name += "[喜茶]";
            Price += 3;
        }
    }
}
