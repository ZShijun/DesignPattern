using System;

namespace DesignPattern.Facade
{
    class Program
    {
        private static readonly Window _window = new Window();
        private static readonly Tv _tv = new Tv();
        private static readonly Light _light = new Light();
        private static readonly AirConditioner _airConditioner = new AirConditioner();
        static void Main(string[] args)
        {
            //BackHome();
            //Sleep();
            //LeaveHome();
            OneClickFacade oneClickFacade = new OneClickFacade();
            oneClickFacade.BackHome();
            oneClickFacade.Sleep();
            oneClickFacade.LeaveHome();
        }

        private static void BackHome()
        {
            Console.WriteLine("--------回家--------");
            _light.TurnOn();
            _tv.TurnOn();
            _airConditioner.TurnOn();
            _window.Open();
        }

        private static void Sleep()
        {
            Console.WriteLine("--------睡觉--------");
            _window.Close();
            _tv.TurnOff();
            _light.TurnOff();
            _airConditioner.TurnOn();
        }

        private static void LeaveHome()
        {
            Console.WriteLine("--------出门--------");
            _window.Close();
            _tv.TurnOff();
            _light.TurnOff();
            _airConditioner.TurnOff();
        }
    }
}
