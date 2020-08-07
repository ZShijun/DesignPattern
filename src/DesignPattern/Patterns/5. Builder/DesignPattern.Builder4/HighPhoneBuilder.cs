using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder4
{
    public class HighPhoneBuilder : PhoneBuilder
    {
        public override void BuildCpu()
        {
            Phone.Cpu = new HighCpu();
        }

        public override void BuildMem()
        {
            Phone.Mem = new HighMem();
        }

        public override void BuildScreen()
        {
            Phone.Screen = new HighScreen();
        }
    }
}
