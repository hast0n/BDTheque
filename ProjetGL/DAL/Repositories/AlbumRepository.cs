using System.Collections.Generic;
using System.Linq;
using DAL.Services;
using Domain;

namespace DAL.Repositories
{
    public class AlbumRepository : Repository, IAlbumRepository
    {

        public IList<Album> GetByTitle(string title)
        {
            return Session.Query<Album>()
                .Where(a => a.Title.Contains(title))
                .ToList();
        }

        public IList<Album> GetByAuthor(string author)
        {
            return Session.Query<Author>()
                .SingleOrDefault(a => a.Name.Equals(author))
                ?.Albums;
        }

        public IList<Album> GetBySeries(string series)
        {
            return Session.Query<Series>()
                .SingleOrDefault(a => a.Name.Equals(series))
                ?.Albums;
        }

        public IList<Album> GetByGenre(string genre)
        {
            return Session.Query<Genre>()
                .SingleOrDefault(a => a.Name.Equals(genre))
                ?.Albums;
        }

        public void Save(Album album)
        {
            Session.SaveOrUpdate(album);
            Session.Flush();
        }
        
        public Album GetAlbumById(int id)
        {
            return Session.Query<Album>().SingleOrDefault(a => a.Id == id);
        }
        
        public IList<Album> GetAll() => Session.Query<Album>().ToList();

        public IList<Album> GetMarketAlbums() => Session.Query<Album>().ToList();
    }
}
