using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder5
{
    public class PhoneBuilder:IPhoneBuilder
    {
        private Phone _phone;
        private Cpu _cpu;
        private Mem _mem;
        private Screen _screen;

        public IPhoneBuilder BuildCpu(Action<Cpu> buildCpuDelegate)
        {
            _cpu = new Cpu();
            buildCpuDelegate?.Invoke(_cpu);
            return this;
        }

        public IPhoneBuilder BuildMem(Action<Mem> buildMemDelegate)
        {
            _mem = new Mem();
            buildMemDelegate?.Invoke(_mem);
            return this;
        }

        public IPhoneBuilder BuildScreen(Action<Screen> buildScreenDelegate)
        {
            _screen = new Screen();
            buildScreenDelegate?.Invoke(_screen);
            return this;
        }

        public Phone Build()
        {
            _phone = new Phone();
            _phone.Cpu = _cpu??new Cpu() { Type="4核8线程"};
            _phone.Mem = _mem ?? new Mem() { Type = "8G" };
            _phone.Screen = _screen ?? new Screen() { Type = "7寸" };
            return _phone;
        }
    }
}
