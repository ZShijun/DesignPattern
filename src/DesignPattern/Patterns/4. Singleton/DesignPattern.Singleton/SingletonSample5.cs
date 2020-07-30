using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    public class SingletonSample5
    {
        private static volatile SingletonSample5 _instance;
        private static readonly object _locker = new object();
        private int _counter = 0;

        private SingletonSample5() { }

        public static SingletonSample5 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonSample5();
                        }
                    }
                }

                return _instance;
            }
        }

        public int IncreaseCount()
        {
            return ++_counter;
        }
    }
}
