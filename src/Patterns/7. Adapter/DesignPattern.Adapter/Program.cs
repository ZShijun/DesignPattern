using System;

namespace DesignPattern.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            Sd sd = new Sd();
            computer.SetUsb(new SdReader(sd));
            computer.ConnectUsb();
        }
    }
}
