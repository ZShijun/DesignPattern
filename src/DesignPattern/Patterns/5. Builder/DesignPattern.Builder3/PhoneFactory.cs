using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder3
{
    public class PhoneFactory
    {
        private PhonePartBuilder _phonePartBuilder;

        public PhoneFactory(PhonePartBuilder phonePartBuilder)
        {
            _phonePartBuilder = phonePartBuilder;
        }

        public void SetPhoneBuilder(PhonePartBuilder phonePartBuilder)
        {
            _phonePartBuilder = phonePartBuilder;
        }

        public Phone BuildPhone()
        {
            Phone phone = new Phone();
            phone.Cpu = _phonePartBuilder?.BuildCpu();
            phone.Mem = _phonePartBuilder?.BuildMem();
            phone.Screen = _phonePartBuilder?.BuildScreen();
            return phone;
        }
    }
}
