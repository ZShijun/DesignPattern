using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State4
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
                _currentState.Handle(this);
            }
        }

        public void SetState(TrafficLightState state)
        {
            _currentState = state;
        }
    }
}
