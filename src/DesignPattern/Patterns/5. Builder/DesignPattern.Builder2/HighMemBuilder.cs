using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder2
{
    public class HighMemBuilder : MemBuilder
    {
        public override Mem BuildMem()
        {
            return new HighMem();
        }
    }
}
