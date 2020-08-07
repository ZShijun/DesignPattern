using System;

namespace DesignPattern.Builder2
{
    class Program
    {
        static void Main(string[] args)
        {
            ScreenBuilder highScreenBuilder = new HighScreenBuilder();
            CpuBuilder highCpuBuilder = new HighCpuBuilder();
            MemBuilder highMemBuilder = new HighMemBuilder();

            Phone phone = new Phone(highScreenBuilder,
                highCpuBuilder,
                highMemBuilder);
            phone.Show();
            Console.WriteLine();

            ScreenBuilder lowScreenBuilder = new LowScreenBuilder();
            CpuBuilder lowCpuBuilder = new LowCpuBuilder();
            MemBuilder lowMemBuilder = new LowMemBuilder();
            Phone lowPhone = new Phone(lowScreenBuilder,
                lowCpuBuilder,
                lowMemBuilder);
            lowPhone.Show();
        }
    }
}
