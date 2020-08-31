using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite2
{
    public abstract class Component
    {
        public string Name { get; set; }

        public Component(string name)
        {
            this.Name = name;
        }

        public abstract int SumArticleCount();

        public abstract void Display(int depth);
    }
}
