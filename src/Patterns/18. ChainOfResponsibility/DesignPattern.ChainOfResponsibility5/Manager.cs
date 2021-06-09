using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility5
{
    public abstract class Manager
    {
        public Manager NextManager { get; set; }

        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }

        public void HandleRequest(LeaveContext context)
        {
            if (CanHandle(context))
            {
                Handle(context);
                return;
            }

            NextManager?.HandleRequest(context);
        }

        protected abstract bool CanHandle(LeaveContext context);

        protected abstract void Handle(LeaveContext context);
    }
}
