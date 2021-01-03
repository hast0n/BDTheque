using System.Collections.Generic;
using System.Linq;
using DAL.Services;
using Domain;

namespace DAL.Repositories
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
