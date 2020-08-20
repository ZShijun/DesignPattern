using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade
{
    public class Window
    {
        public void Open()
        {
            Console.WriteLine("开窗...");
        }

        public void Close()
        {
            Console.WriteLine("关窗...");
        }
    }
}
