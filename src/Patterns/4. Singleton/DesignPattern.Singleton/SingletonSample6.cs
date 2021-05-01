using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    public class SingletonSample6
    {
        private static readonly Lazy<SingletonSample6> _instance
            = new Lazy<SingletonSample6>(() => new SingletonSample6());

        private int _counter = 0;

        private SingletonSample6() { }

        public static SingletonSample6 Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public int IncreaseCount()
        {
            return ++_counter;
        }
    }
}
