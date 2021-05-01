using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod
{
    public abstract class AnimalToFridge
    {
        public void Do()
        {
            OpenFridge();

            PutIntoFridge();

            CloseFridge();
        }

        private void OpenFridge()
        {
            Console.WriteLine("把冰箱门打开");
        }

        public abstract void PutIntoFridge();

        private void CloseFridge()
        {
            Console.WriteLine("把冰箱门关上");
        }
    }
}
