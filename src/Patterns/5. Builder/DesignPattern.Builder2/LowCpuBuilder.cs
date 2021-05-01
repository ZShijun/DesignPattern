using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder2
{
    public class LowCpuBuilder : CpuBuilder
    {
        public override Cpu BuildCpu()
        {
            return new LowCpu();
        }
    }
}
