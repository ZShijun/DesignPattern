using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class JiaTangJiaBingZhenzhuNaicha : ZhenzhuNaicha
    {
        public JiaTangJiaBingZhenzhuNaicha()
        {
            Name += "+糖+冰";
        }
    }
}
