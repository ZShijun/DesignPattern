using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Facade2.Repositories
{
    public class Test2Repository : ITest2Repository
    {
        public void Method3()
        {
            Console.WriteLine("Test2Repository:Method1");
        }

        public void Method4()
        {
            Console.WriteLine("Test2Repository:Method2");
        }
    }
}
