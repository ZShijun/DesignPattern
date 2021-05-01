using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }

        public override void Add(Component component)
        {
            throw new InvalidOperationException("叶子节点不能添加元素");
        }

        public override void Remove(Component component)
        {
            throw new InvalidOperationException("叶子节点不能删除元素");
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
