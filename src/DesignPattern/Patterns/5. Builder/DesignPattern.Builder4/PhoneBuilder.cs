using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder4
{
    public abstract class PhoneBuilder
    {
        protected Phone Phone;
        public PhoneBuilder()
        {
            Phone = new Phone();
        }

        public abstract void BuildCpu();
        public abstract void BuildMem();
        public abstract void BuildScreen();

        public Phone Build()
        {
            BuildCpu();
            BuildMem();
            BuildScreen();
            return Phone;
        }
    }
}
