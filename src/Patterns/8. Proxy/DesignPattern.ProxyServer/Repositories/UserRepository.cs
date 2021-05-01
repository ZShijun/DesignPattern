using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ProxyServer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _users = new List<User>
        {
        new User{Id=1,Name="zs"},
        new User{Id=2,Name="ls" },
        new User{Id=3,Name="ww" }
        };

        public void Add(User user)
        {
            if (user is null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            _users.Add(user);
        }

        public void Delete(int id)
        {
            User user = _users
                .FirstOrDefault(u => u.Id == id);
            if(user != null)
            {
                _users.Remove(user);
            }
        }

        public User Get(int id)
        {
           return _users
               .FirstOrDefault(u => u.Id == id);
        }

        public void Update(User user)
        {
            if (user is null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            User myUser = _users
                .FirstOrDefault(u => u.Id == user.Id);

            if (myUser is null)
            {
                _users.Add(user);
            }
            else
            {
                myUser.Name = user.Name;
            }
        }
    }
}
