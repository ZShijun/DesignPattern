using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod
{
    public class DogToFridge: AnimalToFridge
    {
        public override void PutIntoFridge()
        {
            Console.WriteLine("把狗放进去");
        }
    }
}
