using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite
{
    public class Node
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ParentId { get; set; }
    }
}
