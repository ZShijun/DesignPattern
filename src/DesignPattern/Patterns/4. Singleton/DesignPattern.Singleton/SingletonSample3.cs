using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    public class SingletonSample3
    {
        private static SingletonSample3 _instance;

        private int _counter = 0;

        private SingletonSample3() { }

        public static SingletonSample3 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingletonSample3();
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
