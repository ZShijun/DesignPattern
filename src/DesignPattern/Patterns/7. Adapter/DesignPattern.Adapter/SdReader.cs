using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    public class SdReader : IUsb
    {
        private Sd _sd;

        public SdReader(Sd sd)
        {
            _sd = sd;
        }

        public void Request()
        {
            _sd.ReadWrite();
        }
    }
}
