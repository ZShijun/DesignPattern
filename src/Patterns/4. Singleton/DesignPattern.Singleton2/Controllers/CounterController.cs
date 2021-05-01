using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Singleton2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CounterController : ControllerBase
    {
        private readonly SingletonSample _singletonSample;

        public CounterController(SingletonSample singletonSample)
        {
            this._singletonSample = singletonSample;
        }

        [HttpGet]
        public string Get()
        {
            int count1 = this._singletonSample.IncreaseCount();
            int count2 = this._singletonSample.IncreaseCount();
            return $"count1={count1},count2={count2}";
        }
    }
}
