using DesignPattern.ProxyServer.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ProxyServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var user = _userRepository.Get(id);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            _userRepository.Add(user);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(User user)
        {
            _userRepository.Update(user);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _userRepository.Delete(id);
            return Ok();
        }
    }
}
