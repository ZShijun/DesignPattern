using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Facade2.Repositories
{
    public class Test1Repository : ITest1Repository
    {
        public void Method1()
        {
            Console.WriteLine("Test1Repository:Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Test1Repository:Method2");
        }
    }
}
