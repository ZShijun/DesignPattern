using System;

namespace DesignPattern.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalToFridge dogToFridge = new DogToFridge();
            dogToFridge.Do();
        }
    }
}
