using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
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

        public override void HandleRequest(LeaveContext context)
        {
            if (context.Request.LeaveDays <= 1)
            {
                context.Response = new LeaveResponse
                {
                    Approver = "TL:" + Name,
                    IsAgreed = true
                };
            }
        }
    }
}
