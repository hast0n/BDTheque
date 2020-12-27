﻿using System;
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

        public bool CheckUser(string username, string passwordHash)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string username)
        {
            throw new NotImplementedException();
        }
    }
}
