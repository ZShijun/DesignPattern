using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite
{
    public class Composite : Component
    {
        private List<Component> _components = new List<Component>();

        public Composite(string name):base(name)
        {

        }
        public override void Add(Component component)
        {
            _components.Add(component);
        }

        public override void Remove(Component component)
        {
            _components.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
            foreach (Component component in _components)
            {
                component.Display(depth + 1);
            }
        }

        public override int SumArticleCount()
        {
            int count = 0;
            foreach (var item in _components)
            {
                count += item.SumArticleCount();
            }
            return count;
        }
    }
}
