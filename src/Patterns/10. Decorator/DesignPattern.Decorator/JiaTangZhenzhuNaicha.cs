using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class JiaTangZhenzhuNaicha : ZhenzhuNaicha
    {
        public JiaTangZhenzhuNaicha()
        {
            Name += "+糖";
        }
    }
}
