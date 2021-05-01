using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder3
{
    public abstract class PhonePartBuilder
    {
        public abstract Cpu BuildCpu();
        public abstract Mem BuildMem();
        public abstract Screen BuildScreen();
    }
}
