using System;
using System.Net.Http;

namespace DesignPattern.ProxyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var client = new HttpClient())
            //{
            //    var result = client
            //        .GetAsync("https://localhost:5001/user?id=1")
            //        .GetAwaiter()
            //        .GetResult();
            //    var strResult = result.Content
            //        .ReadAsStringAsync()
            //        .GetAwaiter()
            //        .GetResult();
            //    Console.WriteLine(strResult);
            //    Console.ReadKey();
            //}
            IUserProxy userProxy = new UserProxy();
            string user = userProxy.GetUserById(2);
            Console.WriteLine(user);
            Console.ReadKey();
        }
    }
}
