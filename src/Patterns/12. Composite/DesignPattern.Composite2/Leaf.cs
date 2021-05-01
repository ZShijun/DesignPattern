using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite2
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }

        public override int SumArticleCount()
        {
            return 1;
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }

    }
}
