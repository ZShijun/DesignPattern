using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility3
{
    /// <summary>
    /// 请假申请
    /// </summary>
    public class LeaveRequest
    {
        /// <summary>
        /// 申请人
        /// </summary>
        public string Applicant { get; set; }

        /// <summary>
        /// 请假天数
        /// </summary>
        public int LeaveDays { get; set; }

        /// <summary>
        /// 请假理由
        /// </summary>
        public string Reason { get; set; }
    }
}
