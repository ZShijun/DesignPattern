using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    public sealed class SingletonSample2
    {
        private static readonly SingletonSample2 _instance = new SingletonSample2();

        private int _counter = 0;

        private SingletonSample2() { }

        public static SingletonSample2 Instance
        {
            get
            {
                return _instance;
            }
        }

        public int IncreaseCount()
        {
            return ++_counter;
        }
    }
}
