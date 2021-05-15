using System;

namespace DesignPattern.Observer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Wife wife = new Wife();
            Husband husband = new Husband();
            Son son = new Son();
            dog.AddObserver(wife);
            dog.AddObserver(husband);
            dog.AddObserver(son);
            dog.Bark();
            Console.WriteLine("----------------------");
            dog.RemoveObserver(son);
            dog.Bark();
        }
    }
}
