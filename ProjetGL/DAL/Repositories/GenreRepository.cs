using System.Collections.Generic;
using System.Linq;
using DAL.Services;
using Domain;

namespace DAL.Repositories
{
    class GenreRepository: Repository//, IGenreRepository
    {
        public List<Genre> GetAll()
        {
            return Session.Query<Genre>().ToList();
        }

        public void Save(Genre genre)
        {
            Session.SaveOrUpdate(genre);
            Session.Flush();
        }
    }
}
