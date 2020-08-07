using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder4
{
    public class LowMem : Mem
    {
        public override string Type { get; set; } = "2G";
    }
}
