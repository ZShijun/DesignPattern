using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod2
{
    public abstract class AnimalToFridge
    {
        public void Do()
        {
            OpenFridge();

            BeforePutIntoFridge();

            PutIntoFridge();

            CloseFridge();
        }

        private void OpenFridge()
        {
            Console.WriteLine("把冰箱门打开");
        }

        protected virtual void BeforePutIntoFridge() { }

        protected abstract void PutIntoFridge();

        private void CloseFridge()
        {
            Console.WriteLine("把冰箱门关上");
        }
    }
}
