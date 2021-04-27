using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State2
{
    public class TrafficLight
    {
        private TrafficLightState _currentState;

        public void Shine()
        {
            if (_currentState != null)
            {
                _currentState.Handle(this);
            }
        }

        public void SetState(TrafficLightState state)
        {
            _currentState = state;
        }
    }
}
