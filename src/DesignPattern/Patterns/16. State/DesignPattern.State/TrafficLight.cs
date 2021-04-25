using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    public class TrafficLight
    {
        private LightColor _lightColor;

        public void Shine()
        {
            if (_lightColor == LightColor.Red)
            {
                Console.WriteLine("红灯停");
            }
            else if(_lightColor==LightColor.Green)
            {
                Console.WriteLine("绿灯行");
            }
            else if (_lightColor == LightColor.Yellow)
            {
                Console.WriteLine("黄灯亮了等一等");
            }
        }

        public void ChangeColor(LightColor lightColor)
        {
            _lightColor = lightColor;
        }
    }
}
