using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    class GenreRepository: Repository, IGenreRepository
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
