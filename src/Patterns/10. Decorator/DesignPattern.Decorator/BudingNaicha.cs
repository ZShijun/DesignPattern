using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class BudingNaicha:Naicha
    {
        public BudingNaicha()
        {
            Name += "+布丁";
            Price += 2;
        }
    }
}
