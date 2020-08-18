using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DesignPattern.ProxyClient
{
    public class UserProxy : IUserProxy
    {
        public string GetUserById(int id)
        {
            using (var client = new HttpClient())
            {
                var result = client
                    .GetAsync($"https://localhost:5001/user?id={id}")
                    .GetAwaiter()
                    .GetResult();
                return result.Content
                    .ReadAsStringAsync()
                    .GetAwaiter()
                    .GetResult();
            }
        }
    }
}
