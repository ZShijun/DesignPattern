using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeaveController : ControllerBase
    {
        private readonly IManagerBuilder _managerBuilder;
        private readonly ILogger<LeaveController> _logger;

        public LeaveController(
            IManagerBuilder managerBuilder,
            ILogger<LeaveController> logger)
        {
            _managerBuilder = managerBuilder;
            _logger = logger;
        }

        [HttpGet, Route("{leaveDays}")]
        public string Get(int leaveDays)
        {
            LeaveContext context = new LeaveContext
            {
                Request = new LeaveRequest
                {
                    Applicant = "张三",
                    Reason = "世界那么大，我想去看看",
                    LeaveDays = leaveDays
                }
            };
            Manager manager = _managerBuilder.Build();
            manager.HandleRequest(context);
            if (context.Response == null)
            {
                return $"{context.Request.LeaveDays}天假期太长，没人处理请假申请,请假失败";
            }
            else
            {
                return $"{context.Response.Approver}审批了{context.Request.Applicant}的{context.Request.LeaveDays}天请假申请";
            }
        }
    }
}
