using System;

namespace DesignPattern.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone highPhone = new Phone();
            highPhone.Cpu = new HighCpu();
            highPhone.Mem = new HighMem();
            highPhone.Screen = new HighScreen();
            highPhone.Show();
            Console.WriteLine();

            Phone lowPhone = new Phone();
            lowPhone.Cpu = new LowCpu();
            lowPhone.Mem = new LowMem();
            lowPhone.Screen = new LowScreen();
            lowPhone.Show();
        }
    }
}
