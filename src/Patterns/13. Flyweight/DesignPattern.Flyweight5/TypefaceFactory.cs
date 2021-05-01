using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight5
{
    public class TypefaceFactory
    {
        private static readonly IDictionary<Type, Typeface> _typefaces 
            = new Dictionary<Type, Typeface>();

        private static readonly object _locker = new object();
        public static Typeface GetTypeface<TTypeface>() where TTypeface : Typeface
        {
            Type type = typeof(TTypeface);
            if (!_typefaces.ContainsKey(type))
            {
                lock (_locker)
                {
                    if (!_typefaces.ContainsKey(type))
                    {
                        Typeface typeface = Activator.CreateInstance(typeof(TTypeface)) as Typeface;
                        _typefaces.Add(type, typeface);
                    }
                }
            }

            return _typefaces[type];
        }
    }
}
