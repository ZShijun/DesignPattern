using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility4
{
    /// <summary>
    /// 团队领导者
    /// </summary>
    public class TL : Manager
    {
        public TL(string name)
            : base(name)
        {
        }

        protected override bool CanHandle(LeaveContext context)
        {
            return context.Request.LeaveDays <= 1;
        }

        protected override void Handle(LeaveContext context)
        {
            context.Response = new LeaveResponse
            {
                Approver = "TL:" + Name,
                IsAgreed = true
            };
        }
    }
}
