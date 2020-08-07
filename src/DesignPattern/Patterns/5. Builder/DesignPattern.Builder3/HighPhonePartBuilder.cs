using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder3
{
    public class HighPhonePartBuilder : PhonePartBuilder
    {
        public override Cpu BuildCpu()
        {
            return new HighCpu();
        }

        public override Mem BuildMem()
        {
            return new HighMem();
        }

        public override Screen BuildScreen()
        {
            return new HighScreen();
        }
    }
}
