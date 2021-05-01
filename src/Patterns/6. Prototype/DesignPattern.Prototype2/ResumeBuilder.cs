using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype2
{
    public class ResumeBuilder : IResumeBuilder
    {
        private readonly BasicInfo _basicInfo = new BasicInfo();
        private readonly WorkExperence _workExperence = new WorkExperence();

        public IResumeBuilder BuildBasicInfo(Action<BasicInfo> buildBasicInfoDelegate)
        {
            buildBasicInfoDelegate?.Invoke(_basicInfo);
            return this;
        }

        public IResumeBuilder BuildWorkExperence(Action<WorkExperence> buildWorkExperenceDelegate)
        {
            buildWorkExperenceDelegate?.Invoke(_workExperence);
            return this;
        }

        public ResumeBase Build()
        {
            ItResume resume = new ItResume()
            {
                Name = this._basicInfo.Name,
                Gender = this._basicInfo.Gender,
                Age = this._basicInfo.Age,
                ExpectedSalary = this._basicInfo.ExpectedSalary,
                WorkExperence = new WorkExperence
                {
                    Company = this._workExperence.Company,
                    Detail = this._workExperence.Detail,
                    StartDate = this._workExperence.StartDate,
                    EndDate = this._workExperence.EndDate
                }
            };
            return resume;
        }
    }
}
