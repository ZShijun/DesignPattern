using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DesignPattern.Prototype5
{
    [Serializable]
    public class ItResume : ICloneable
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

        /// <summary>
        /// 工作经历
        /// </summary>
        public WorkExperence WorkExperence { get; set; }

        public void Display()
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

        public object Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, this);
                stream.Position = 0;
                return bf.Deserialize(stream);
            }
        }
    }
}
