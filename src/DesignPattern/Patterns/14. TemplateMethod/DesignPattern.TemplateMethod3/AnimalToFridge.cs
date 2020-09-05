using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod3
{
    public class AnimalToFridge
    {
        public void Do(Action beforePutIntoFridge,Action putIntoFridge)
        {
            OpenFridge();

            beforePutIntoFridge?.Invoke();

            putIntoFridge?.Invoke();

            CloseFridge();
        }

        private void OpenFridge()
        {
            Console.WriteLine("把冰箱门打开");
        }

        private void CloseFridge()
        {
            Console.WriteLine("把冰箱门关上");
        }
    }
}
