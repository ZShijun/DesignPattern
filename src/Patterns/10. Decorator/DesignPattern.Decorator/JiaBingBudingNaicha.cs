using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class JiaBingBudingNaicha : BudingNaicha
    {
        public JiaBingBudingNaicha()
        {
            Name += "+冰";
        }
    }
}
