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
        /// Check if user exists
        /// </summary>
        /// <param name="username">User identifier (email)</param>
        /// <param name="passwordHash">password hash (SHA-256 string)</param>
        /// <returns>A boolean indicating whether user exists in database</returns>
        bool CheckUser(string username, string passwordHash);

        /// <summary>
        /// Get user object from database entry
        /// </summary>
        /// <param name="username">User identifier (email)</param>
        /// <returns>A user object</returns>
        User GetUser(string username);

        /// <summary>
        /// Persist new user in database
        /// </summary>
        /// <param name="user">The user object</param>
        void AddUser(User user);
    }
}
