using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility4
{
    /// <summary>
    /// 项目经理
    /// </summary>
    public class PM : Manager
    {
        public PM(string name)
            : base(name)
        {

        }

        protected override bool CanHandle(LeaveContext context)
        {
            return context.Request.LeaveDays > 1
                && context.Request.LeaveDays <= 3;
        }

        protected override void Handle(LeaveContext context)
        {
            context.Response = new LeaveResponse
            {
                Approver = "PM:" + Name,
                IsAgreed = true
            };
        }
    }
}
