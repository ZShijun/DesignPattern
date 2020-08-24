using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator3
{
    public class Buding : Peiliao
    {
        public override string Name => "布丁";

        public override int Price => 2;
    }
}
