using Domain;
using System.Collections.Generic;

namespace DAL.Services
{
    public interface IAlbumRepository
    {
        void Save(Album album);
        Album GetAlbumById(int number);
        IList<Album> GetAll();
    }
}
