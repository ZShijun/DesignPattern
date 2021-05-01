using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder4
{
    public class LowCpu : Cpu
    {
        public override string Type { get; set; } = "双核4线程";
    }
}
