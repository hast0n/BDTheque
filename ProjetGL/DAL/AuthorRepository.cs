using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    class AuthorRepository: Repository, IAuthorRepository
    {
        public List<Author> GetAll()
        {
            return Session.Query<Author>().ToList();
        }

        public void Save(Author author)
        {
            Session.SaveOrUpdate(author);
            Session.Flush();
        }
    }
}
