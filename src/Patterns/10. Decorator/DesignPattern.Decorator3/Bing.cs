using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator3
{
    public class Bing : Peiliao
    {
        public override string Name => "冰";
        public override int Price => 0;
    }
}
