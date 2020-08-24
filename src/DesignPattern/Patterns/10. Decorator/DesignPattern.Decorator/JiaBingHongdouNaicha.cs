using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class JiaBingHongdouNaicha : HongDouNaicha
    {
        public JiaBingHongdouNaicha()
        {
            Name += "+冰";
        }
    }
}
