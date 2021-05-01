using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod2
{
    public class ElephantToFridge : AnimalToFridge
    {
        protected override void PutIntoFridge()
        {
            Console.WriteLine("把大象放进去");
        }
    }
}
