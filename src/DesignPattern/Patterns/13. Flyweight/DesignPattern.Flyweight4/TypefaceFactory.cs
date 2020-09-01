using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight4
{
    public class TypefaceFactory
    {
        private static readonly IDictionary<Type, Typeface> _typefaces 
            = new Dictionary<Type, Typeface>();

        public static Typeface GetTypeface<TTypeface>() where TTypeface : Typeface
        {
            Type type = typeof(TTypeface);
            if (_typefaces.ContainsKey(type))
            {
                return _typefaces[type];
            }

            Typeface typeface = Activator.CreateInstance(typeof(TTypeface)) as Typeface;
            _typefaces.Add(type, typeface);
            return typeface;
        }
    }
}
