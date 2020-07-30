using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    public static class SingletonSample1
    {
        private static int _counter = 0;

        public static int IncreaseCount()
        {
            return ++_counter;
        }
    }
}
