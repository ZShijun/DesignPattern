using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    public class SingletonSample4
    {
        private static SingletonSample4 _instance;
        private static readonly object _locker = new object();
        private int _counter = 0;

        private SingletonSample4() { }

        public static SingletonSample4 Instance
        {
            get
            {
                lock (_locker)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonSample4();
                    }

                    return _instance;
                }
            }
        }

        public int IncreaseCount()
        {
            return ++_counter;
        }
    }
}
