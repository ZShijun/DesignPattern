using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype3
{
    /// <summary>
    /// 工作经历
    /// </summary>
    public class WorkExperence
    {
        public string Company { get; set; }

        public string Detail { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public void Display()
        {
            Console.WriteLine("工作经历:");
            Console.WriteLine($"{this.Company}\t{this.StartDate.ToShortDateString()}-{EndDate.ToShortDateString()}");
            Console.WriteLine("工作详细:");
            Console.WriteLine(this.Detail);
        }

        public WorkExperence Clone()
        {
            return this.MemberwiseClone() as WorkExperence;
        }
    }
}
