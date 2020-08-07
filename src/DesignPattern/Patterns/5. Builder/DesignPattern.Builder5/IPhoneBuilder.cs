using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder5
{
    public interface IPhoneBuilder
    {
        IPhoneBuilder BuildCpu(Action<Cpu> buildCpuDelegate);
        IPhoneBuilder BuildMem(Action<Mem> buildMemDelegate);
        IPhoneBuilder BuildScreen(Action<Screen> buildScreenDelegate);
        Phone Build();
    }
}
