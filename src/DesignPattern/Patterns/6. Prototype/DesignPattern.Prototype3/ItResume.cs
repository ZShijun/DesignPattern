using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype3
{
    public sealed class ItResume : ResumeBase
    {
        public ItResume()
        {

        }
        /// <summary>
        /// 工作经历
        /// </summary>
        public WorkExperence WorkExperence { get; set; }

        public override void Display()
        {
            Console.WriteLine($"姓名:\t{this.Name}");
            Console.WriteLine($"性别:\t{this.Gender}");
            Console.WriteLine($"年龄:\t{this.Age}");
            Console.WriteLine($"期望薪资:\t{this.ExpectedSalary}");
            Console.WriteLine("--------------------------------");
            if (this.WorkExperence != null)
            {
                this.WorkExperence.Display();
            }

            Console.WriteLine("--------------------------------");
        }

        public override ResumeBase Clone()
        {
            ItResume itResume = this.MemberwiseClone() as ItResume;
            itResume.WorkExperence = this.WorkExperence.Clone();
            return itResume;
        }
    }
}
