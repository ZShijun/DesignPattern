using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility2
{
    public abstract class Manager
    {
        public Manager NextManager { get; set; }

        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }

        public abstract void HandleRequest(LeaveContext context);
    }
}
