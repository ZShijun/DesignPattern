using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder3
{
    public class LowPhonePartBuilder : PhonePartBuilder
    {
        public override Cpu BuildCpu()
        {
            return new LowCpu();
        }

        public override Mem BuildMem()
        {
            return new LowMem();
        }

        public override Screen BuildScreen()
        {
            return new LowScreen();
        }
    }
}
