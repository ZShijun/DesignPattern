using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod2
{
    public class GiraffeToFridge : AnimalToFridge
    {
        protected override void BeforePutIntoFridge()
        {
            Console.WriteLine("把大象弄出来");
        }

        protected override void PutIntoFridge()
        {
            Console.WriteLine("把长颈鹿放进去");
        }
    }
}
