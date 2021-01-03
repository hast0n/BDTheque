using System.Collections.Generic;
using System.Linq;
using DAL.Services;
using Domain;

namespace DAL.Repositories
{
    class AlbumRepository :Repository, IAlbumRepository
    {
        public List<Album> GetAll()
        {
            return Session.Query<Album>().ToList();
        }

        public void Save(Album album)
        {
            Session.SaveOrUpdate(album);
            Session.Flush();
        }
    }
}
