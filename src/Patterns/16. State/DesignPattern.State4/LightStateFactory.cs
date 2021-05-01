using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State4
{
    public class LightStateFactory
    {
        private static readonly IDictionary<Type, TrafficLightState> _lightStates
               = new Dictionary<Type, TrafficLightState>();

        private static readonly object _locker = new object();
        public static TrafficLightState GetLightState<TLightState>() where TLightState : TrafficLightState
        {
            Type type = typeof(TLightState);
            if (!_lightStates.ContainsKey(type))
            {
                lock (_locker)
                {
                    if (!_lightStates.ContainsKey(type))
                    {
                        TrafficLightState typeface = Activator.CreateInstance(typeof(TLightState)) as TrafficLightState;
                        _lightStates.Add(type, typeface);
                    }
                }
            }

            return _lightStates[type];
        }
    }
}
