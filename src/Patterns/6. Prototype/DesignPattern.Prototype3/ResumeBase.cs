using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype3
{
    public abstract class ResumeBase
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 期望薪资
        /// </summary>
        public string ExpectedSalary { get; set; }

        public abstract void Display();

        public abstract ResumeBase Clone();
    }
}
