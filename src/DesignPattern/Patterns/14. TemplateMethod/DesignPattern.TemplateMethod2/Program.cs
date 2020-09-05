using System;

namespace DesignPattern.TemplateMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalToFridge elephant = new ElephantToFridge();
            elephant.Do();
            Console.WriteLine("--------------");
            AnimalToFridge giraffe = new GiraffeToFridge();
            giraffe.Do();
        }
    }
}
