using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    public class HighMem:Mem
    {
        public override string Type { get; set; } = "8G";
    }
}
