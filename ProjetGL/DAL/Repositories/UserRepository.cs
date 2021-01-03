using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Services;
using Domain;

namespace DAL.Repositories
{
    public class UserRepository : Repository, IUserRepository
    {
        public List<User> GetAll()
        {
            return Session.Query<User>().ToList();
        }

        public void Save(User user)
        {
            Session.SaveOrUpdate(user);
            Session.Flush();
        }
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
