using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder2
{
    public class LowMemBuilder : MemBuilder
    {
        public override Mem BuildMem()
        {
            return new LowMem();
        }
    }
}
