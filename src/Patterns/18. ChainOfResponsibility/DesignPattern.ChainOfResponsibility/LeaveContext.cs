using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// 请假单
    /// </summary>
    public class LeaveContext
    {
        /// <summary>
        /// 申请
        /// </summary>
        public LeaveRequest Request { get; set; }

        /// <summary>
        /// 审批结果
        /// </summary>
        public LeaveResponse Response { get; set; }
    }
}
