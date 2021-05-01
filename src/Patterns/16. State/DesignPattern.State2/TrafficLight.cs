using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State2
{
    public class TrafficLight
    {
        private TrafficLightState _currentState;

        public TrafficLight()
        {
            _currentState = new RedState();
        }

        public void Turn()
        {
            if (_currentState != null)
            {
                _currentState.Handle();
            }
        }

        public void SetState(TrafficLightState state)
        {
            _currentState = state;
        }
    }
}
