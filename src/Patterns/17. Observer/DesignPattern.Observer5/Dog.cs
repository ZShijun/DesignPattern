using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer5
{
    /// <summary>
    /// 遥闻深巷中犬吠，便有妇人惊觉欠伸，其夫呓语。既而儿醒，大啼。夫亦醒。
    /// </summary>
    public class Dog
    {
        private readonly ISubject _subject;

        public Dog(ISubject subject)
        {
            this._subject = subject;
        }

        public void Bark()
        {
            Console.WriteLine("遥闻深巷中犬吠");

            _subject.Publish(new EventData { Source = this, EventType = "DogBark" });
        }
    }
}
