using DesignPattern.Facade2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Facade2.Services
{
    public class TestService : ITestService
    {
        private readonly ITest1Repository _test1Repository;
        private readonly ITest2Repository _test2Repository;

        public TestService(ITest1Repository test1Repository, ITest2Repository test2Repository)
        {
            this._test1Repository = test1Repository;
            this._test2Repository = test2Repository;
        }

        public void Test()
        {
            this._test1Repository.Method1();
            this._test1Repository.Method2();
            this._test2Repository.Method3();
            this._test2Repository.Method4();
        }
    }
}
