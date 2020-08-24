using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class HongDouNaicha : Naicha
    {
        public HongDouNaicha()
        {
            Name += "+红豆";
            Price += 1;
        }
    }
}
