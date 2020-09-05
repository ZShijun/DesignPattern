using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod
{
    public class ElephantToFridge:AnimalToFridge
    {

        public override void PutIntoFridge()
        {
            Console.WriteLine("把大象放进去");
        }
    }
}
