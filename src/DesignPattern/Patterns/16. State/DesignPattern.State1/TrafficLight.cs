using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State1
{
    public class TrafficLight
    {
        private ITurnStrategy _turnStrategy;

        public TrafficLight(ITurnStrategy turnStrategy)
        {
            _turnStrategy = turnStrategy;
        }

        public void Turn()
        {
            if (_turnStrategy != null)
            {
                _turnStrategy.Turn();
            }
        }

        public void ChangeTurnStrategy(ITurnStrategy turnStrategy)
        {
            _turnStrategy = turnStrategy;
        }
    }
}
