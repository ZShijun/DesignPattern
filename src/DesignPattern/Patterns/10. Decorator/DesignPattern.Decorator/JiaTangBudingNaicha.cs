using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class JiaTangBudingNaicha : BudingNaicha
    {
        public JiaTangBudingNaicha()
        {
            Name += "+糖";
        }
    }
}
