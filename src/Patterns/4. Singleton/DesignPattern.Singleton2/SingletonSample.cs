using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Singleton2
{
    public class SingletonSample
    {
        private int _counter = 0;

        public int IncreaseCount()
        {
            return ++_counter;
        }
    }
}
