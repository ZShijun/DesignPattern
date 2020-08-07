using System;

namespace DesignPattern.Builder5
{
    class Program
    {
        static void Main(string[] args)
        {
            IPhoneBuilder phoneBuilder = new PhoneBuilder();
            Phone phone = phoneBuilder
                .BuildCpu(cpu => { cpu.Type = "8核16线程"; })
                .BuildMem(mem => { mem.Type = "32G"; })
                .BuildScreen(screen => { screen.Type = "10寸"; })
                .Build();
            phone.Show();
        }
    }
}
