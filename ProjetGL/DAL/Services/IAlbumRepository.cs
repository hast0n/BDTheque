using Domain;
using System.Collections.Generic;

namespace DAL.Services
{
    public interface IAlbumRepository
    {
        void Save(Album album);
        Album GetAlbumById(int number);
        IList<Album> GetMarketAlbums();
        void GetOwnedAlbums(User user);//IList<Album>
        void GetWishesAlbums(User user);//IList<Album>
    }
}
