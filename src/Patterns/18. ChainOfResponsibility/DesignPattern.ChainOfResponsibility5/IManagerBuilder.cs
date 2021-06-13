using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility5
{
    public interface IManagerBuilder
    {
        void AddManager(Manager manager);

        Manager Build();
    }
}
