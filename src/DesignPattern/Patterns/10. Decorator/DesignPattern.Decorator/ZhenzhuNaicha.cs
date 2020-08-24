using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class ZhenzhuNaicha : Naicha
    {
        public ZhenzhuNaicha()
        {
            Name += "+珍珠";
            Price += 3;
        }
    }
}
