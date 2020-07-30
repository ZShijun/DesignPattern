using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    public class SingletonSampleBase<TSingleton> where TSingleton : class
    {
        private static readonly Lazy<TSingleton> _instance
            = new Lazy<TSingleton>(() => (TSingleton)Activator.CreateInstance(typeof(TSingleton), true));

        protected SingletonSampleBase() { }

        public static TSingleton Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
