using System;

namespace DesignPattern.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            IResumeBuilder resumeBuilder = new ResumeBuilder()
                .BuildBasicInfo(resume =>
                {
                    resume.Name = "张三";
                    resume.Age = 18;
                    resume.Gender = "男";
                    resume.ExpectedSalary = "100W";
                })
                .BuildWorkExperence(work =>
                {
                    work.Company = "A公司";
                    work.Detail = "负责XX系统开发,精通YY。。。。。";
                    work.StartDate = DateTime.Parse("2019-1-1");
                    work.EndDate = DateTime.Parse("2020-1-1");
                });

            ResumeBase resume1 = resumeBuilder
                .Build();

            ResumeBase resume2 = resumeBuilder
                .BuildBasicInfo(resume =>
                {
                    resume.ExpectedSalary = "面议";
                })
                .BuildWorkExperence(work =>
                {
                    work.Detail = "电商经验丰富";
                })
                .Build();
            resume1.Display();
            Console.WriteLine();
            resume2.Display();
        }
    }
}
