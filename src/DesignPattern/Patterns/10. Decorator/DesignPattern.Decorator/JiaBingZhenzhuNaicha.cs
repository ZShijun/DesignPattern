using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class JiaBingZhenzhuNaicha : ZhenzhuNaicha
    {
        public JiaBingZhenzhuNaicha()
        {
            Name += "+冰";
        }
    }
}
