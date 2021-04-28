using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    public class TrafficLight
    {
        private LightColor _lightColor;
        public TrafficLight()
        {
            _lightColor = LightColor.Red;
        }

        public void Turn()
        {
            if (_lightColor == LightColor.Red)
            {
                Console.WriteLine("红灯停");
                _lightColor = LightColor.Green;
            }
            else if (_lightColor == LightColor.Green)
            {
                Console.WriteLine("绿灯行");
                _lightColor = LightColor.Yellow;
            }
            else if (_lightColor == LightColor.Yellow)
            {
                Console.WriteLine("黄灯亮了等一等");
                _lightColor = LightColor.Red;
            }
        }
    }
}
