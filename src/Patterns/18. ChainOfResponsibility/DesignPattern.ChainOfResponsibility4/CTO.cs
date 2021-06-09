using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility4
{
    /// <summary>
    /// 首席技术官
    /// </summary>
    public class CTO : Manager
    {
        public CTO(string name)
            : base(name)
        {

        }

        protected override bool CanHandle(LeaveContext context)
        {
            return context.Request.LeaveDays > 3
                && context.Request.LeaveDays <= 7;
        }

        protected override void Handle(LeaveContext context)
        {
            context.Response = new LeaveResponse
            {
                Approver = "CTO:" + Name,
                IsAgreed = true
            };
        }
    }
}
