using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder3
{
    public class LowCpu : Cpu
    {
        public override string Type { get; set; } = "双核4线程";
    }
}
