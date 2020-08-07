using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder2
{
    public class HighCpuBuilder : CpuBuilder
    {
        public override Cpu BuildCpu()
        {
            return new HighCpu();
        }
    }
}
