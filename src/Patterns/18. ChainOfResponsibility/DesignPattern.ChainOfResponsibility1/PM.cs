using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility1
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

        public override void HandleRequest(LeaveContext context)
        {
            if (context.Request.LeaveDays > 1
                && context.Request.LeaveDays <= 3)
            {
                context.Response = new LeaveResponse
                {
                    Approver = "PM:" + Name,
                    IsAgreed = true
                };
                return;
            }

            CTO cTO = new CTO("赵六");
            cTO.HandleRequest(context);
        }
    }
}
