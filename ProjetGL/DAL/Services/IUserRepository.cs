using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public interface IUserRepository
    {
        /// <summary>
        /// Get user object from database entry
        /// </summary>
        /// <param name="username">User identifier (email)</param>
        /// <param name="passwordHash">User password hash (email)</param>
        /// <returns>A user object</returns>
        User GetUser(string email, string passwordHash);

        /// <summary>
        /// Persist new user in database
        /// </summary>
        /// <param name="user">The user object</param>
        void AddUser(User user);
    }
}
