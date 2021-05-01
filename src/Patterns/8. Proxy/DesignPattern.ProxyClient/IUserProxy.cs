using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ProxyClient
{
    public interface IUserProxy
    {
        string GetUserById(int id);
    }
}
