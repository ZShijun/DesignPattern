using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ProxyServer.Repositories
{
    public class UserRepositoryProxy : IUserRepository
    {
        private readonly IUserRepository _userRepository = new UserRepository();
        private readonly ILogger<UserRepositoryProxy> _logger;
        public UserRepositoryProxy(ILogger<UserRepositoryProxy> logger)
        {
            this._logger = logger;
        }

        public void Add(User user)
        {
            _logger.LogDebug("UserRepositoryProxy-Add In:UserName={0}", user.Name);
            _userRepository.Add(user);
        }

        public void Delete(int id)
        {
            _logger.LogDebug("UserRepositoryProxy-Delete In:id={0}", id);
            _userRepository.Delete(id);
        }

        public User Get(int id)
        {
            try
            {
                _logger.LogDebug("UserRepositoryProxy-Get In:id={0}", id);
                return _userRepository.Get(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UserRepositoryProxy-Get Error.");
                throw;
            }
            
        }

        public void Update(User user)
        {
            _logger.LogDebug("UserRepositoryProxy-Update In:UserName={0}", user.Name);
            _userRepository.Update(user);
        }
    }
}
