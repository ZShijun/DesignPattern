using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class JiaTangHongdouNaicha : HongDouNaicha
    {
        public JiaTangHongdouNaicha()
        {
            Name += "+糖";
        }
    }
}
