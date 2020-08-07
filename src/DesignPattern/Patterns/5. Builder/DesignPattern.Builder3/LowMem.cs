using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder3
{
    public class LowMem : Mem
    {
        public override string Type { get; set; } = "2G";
    }
}
