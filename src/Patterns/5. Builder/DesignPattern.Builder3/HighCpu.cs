using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder3
{
    public class HighCpu : Cpu
    {
        public override string Type { get; set; } = "6核12线程";
    }
}
