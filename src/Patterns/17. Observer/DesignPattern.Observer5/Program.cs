using System;

namespace DesignPattern.Observer5
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
            Broker.Instance.AddObserver(wife);
            Broker.Instance.AddObserver(husband);
            Broker.Instance.AddObserver(son);

            dog.Bark();
        }
    }
}
