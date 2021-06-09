using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility3
{
    public class HR
    {
        public Manager GetManager()
        {
            TL tL = new TL("李四");
            PM pM = new PM("王五");
            CTO cTO = new CTO("赵六");
            tL.NextManager = pM;
            pM.NextManager = cTO;
            return tL;
        }
    }
}
