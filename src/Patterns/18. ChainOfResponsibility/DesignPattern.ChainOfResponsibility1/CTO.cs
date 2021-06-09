using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility1
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

        public override void HandleRequest(LeaveContext context)
        {
            if (context.Request.LeaveDays > 3
                && context.Request.LeaveDays <= 7)
            {
                context.Response = new LeaveResponse
                {
                    Approver = "CTO:" + Name,
                    IsAgreed = true
                };
            }
        }
    }
}
