using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility1
{
    public abstract class Manager
    {
        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }

        public abstract void HandleRequest(LeaveContext context);
    }
}
