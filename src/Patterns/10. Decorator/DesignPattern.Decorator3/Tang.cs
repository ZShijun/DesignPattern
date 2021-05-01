using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator3
{
    public class Tang : Peiliao
    {
        public override string Name => "糖";

        public override int Price => 0;
    }
}
