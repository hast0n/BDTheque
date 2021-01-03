using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Services;
using Domain;

namespace DAL
{
    public class UserRepository : Repository, IUserRepository
    {
        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string email, string passwordHash)
        {
            var result = Session.Query<User>()
                .Where(u =>
                    u.Email.Equals(email) &&
                    u.PasswordHash.Equals(passwordHash))
                .ToList();
            return result.Count > 0 ? result[0] : null;
        }
    }
}
