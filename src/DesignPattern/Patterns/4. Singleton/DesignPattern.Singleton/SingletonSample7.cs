using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    public class SingletonSample7 : SingletonSampleBase<SingletonSample7>
    {
        private int _counter = 0;

        private SingletonSample7() { }

        public int IncreaseCount()
        {
            return ++_counter;
        }
    }
}
