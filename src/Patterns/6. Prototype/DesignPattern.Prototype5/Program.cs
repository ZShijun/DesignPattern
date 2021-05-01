using System;

namespace DesignPattern.Prototype5
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

            ItResume resume1 = resumeBuilder
                .Build();

            ItResume resume2 = resume1.Clone() as ItResume;
            resume2.ExpectedSalary = "面议";
            resume2.WorkExperence.Detail = "aaaaaa";

            resume1.Display();
            resume2.Display();
        }
    }
}
