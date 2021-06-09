using System;

namespace DesignPattern.ChainOfResponsibility1
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveContext context = new LeaveContext
            {
                Request = new LeaveRequest
                {
                    Applicant = "张三",
                    Reason = "世界那么大，我想去看看",
                    LeaveDays = new Random().Next(1, 10)
                }
            };

            TL tL = new TL("李四");
            tL.HandleRequest(context);

            if (context.Response == null)
            {
                Console.WriteLine($"{context.Request.LeaveDays}天假期太长，没人处理请假申请,请假失败");
            }
            else
            {
                Console.WriteLine($"{context.Response.Approver}审批了{context.Request.Applicant}的{context.Request.LeaveDays}天请假申请");
            }
        }
    }
}
