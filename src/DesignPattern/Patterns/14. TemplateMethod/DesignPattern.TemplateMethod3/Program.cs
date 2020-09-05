using System;

namespace DesignPattern.TemplateMethod3
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalToFridge elephant = new AnimalToFridge();
            elephant.Do(null, () =>
             {
                 Console.WriteLine("把大象放进去");
             });
            Console.WriteLine("--------------");
            AnimalToFridge giraffe = new AnimalToFridge();
            giraffe.Do(() =>
            {
                Console.WriteLine("把大象弄出来");
            }, () =>
            {
                Console.WriteLine("把长颈鹿放进去");
            });
        }
    }
}
