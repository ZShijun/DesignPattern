using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility5
{
    public class HRBuilder
    {
        public HR Build()
        {
            return new HR();
        }
    }
}
