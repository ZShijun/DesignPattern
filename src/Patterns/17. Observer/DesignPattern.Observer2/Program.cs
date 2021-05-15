using System;

namespace DesignPattern.Observer2
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
            son.AddObserver(husband);
            dog.Bark();
        }
    }
}
