using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight6
{
    public class TypefaceFactory
    {
        private static readonly IDictionary<string, Typeface> _typefaces
            = new Dictionary<string, Typeface>();


        private static readonly object _locker = new object();

        public static void SetTypeface(string key, Typeface typeface)
        {
            if (!_typefaces.ContainsKey(key)) 
            {
                lock (_locker)
                {
                    if (!_typefaces.ContainsKey(key))
                    {
                        _typefaces.Add(key, typeface);
                    }
                }
            }
        }

        public static Typeface GetTypeface(string key)
        {
            if (_typefaces.ContainsKey(key))
            {
                return _typefaces[key];
            }

            return null;
        }
    }
}
