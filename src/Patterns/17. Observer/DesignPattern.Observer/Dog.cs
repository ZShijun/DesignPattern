using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    /// <summary>
    /// 遥闻深巷中犬吠，便有妇人惊觉欠伸，其夫呓语。既而儿醒，大啼。
    /// </summary>
    public class Dog
    {
        private readonly Wife _wife = new Wife();
        private readonly Husband _husband = new Husband();
        private readonly Son _son = new Son();
        public void Bark()
        {
            Console.WriteLine("遥闻深巷中犬吠");

            _wife.Wakeup();
            _husband.DreamTalk();
            _son.Wakeup();
        }
    }
}
