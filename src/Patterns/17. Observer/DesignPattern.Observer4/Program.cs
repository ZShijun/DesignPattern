using System;

namespace DesignPattern.Observer4
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Subject();
            Dog dog = new Dog(subject);
            Wife wife = new Wife();
            Husband husband = new Husband();
            Son son = new Son(subject);

            subject.AddObserver(wife);
            subject.AddObserver(husband);
            subject.AddObserver(son);

            dog.Bark();
        }
    }
}
