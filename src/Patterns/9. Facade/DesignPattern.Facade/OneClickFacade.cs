using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade
{
    public class OneClickFacade
    {
        private static readonly Window _window = new Window();
        private static readonly Tv _tv = new Tv();
        private static readonly Light _light = new Light();
        private static readonly AirConditioner _airConditioner = new AirConditioner();

        public void BackHome()
        {
            Console.WriteLine("--------回家--------");
            _tv.TurnOn();
            _light.TurnOn();
            _airConditioner.TurnOn();
            _window.Open();
        }

        public void Sleep()
        {
            Console.WriteLine("--------睡觉--------");
            _window.Close();
            _tv.TurnOff();
            _light.TurnOff();
            _airConditioner.TurnOn();
        }

        public void LeaveHome()
        {
            Console.WriteLine("--------出门--------");
            _window.Close();
            _tv.TurnOff();
            _light.TurnOff();
            _airConditioner.TurnOff();
        }

        public void M1() { 
        
        }

    }
}
