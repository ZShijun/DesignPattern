using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy3
{
    public class BucketFillStrategy : IFillStrategy
    {
        public void Fill()
        {
            Console.WriteLine("用油漆桶填充图形");
        }
    }
}
