using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer2
{
    /// <summary>
    /// 遥闻深巷中犬吠，便有妇人惊觉欠伸，其夫呓语。既而儿醒，大啼。夫亦醒。
    /// </summary>
    public class Dog
    {
        private readonly IList<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Bark()
        {
            Console.WriteLine("遥闻深巷中犬吠");
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
