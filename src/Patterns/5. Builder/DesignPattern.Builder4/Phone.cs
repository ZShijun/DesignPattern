using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder4
{
    public class Phone
    {
        public Cpu Cpu { get; set; }

        public Screen Screen { get; set; }

        public Mem Mem { get; set; }

        public void Show()
        {
            Console.WriteLine("手机配置:");
            Console.WriteLine($"CPU:{Cpu?.Type}");
            Console.WriteLine($"内存:{Mem?.Type}");
            Console.WriteLine($"屏幕:{Screen?.Type}");
        }
    }
}
