using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State1
{
    public class TrafficLight
    {
        private IShineStrategy _shineStrategy;

        public void Shine()
        {
            if (_shineStrategy != null)
            {
                _shineStrategy.Shine();
            }
        }

        public void ChangeShineStrategy(IShineStrategy shineStrategy)
        {
            _shineStrategy = shineStrategy;
        }
    }
}
