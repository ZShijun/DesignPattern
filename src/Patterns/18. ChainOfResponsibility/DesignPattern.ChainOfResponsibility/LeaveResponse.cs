using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// 审批结果
    /// </summary>
    public class LeaveResponse
    {
        /// <summary>
        /// 审批人
        /// </summary>
        public string Approver { get; set; }

        /// <summary>
        /// 是否同意
        /// </summary>
        public bool IsAgreed { get; set; }
    }
}
