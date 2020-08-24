using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator3
{
    public class Zhenzhu : Peiliao
    {
        public override string Name => "珍珠";

        public override int Price => 3;
    }
}
