using System.Collections.Generic;
using System.Linq;
using DAL.Services;
using Domain;

namespace DAL.Repositories
{
    public class AlbumRepository : Repository, IAlbumRepository
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
        public Album GetAlbumById(int id)
        {
            //string requete = "select a from Album a where a.Id=?";
            var album = Session.Query<Album>().SingleOrDefault(a => a.Id == id);

            //var album  = Session.Query<Album>().ToList().Where(a => a.Id == id).FirstOrDefault();
            //var album = Session.CreateQuery(requete).SetInt32(0, id).List<Album>();
            return album;
            //return Session.Query<Album>().SingleOrDefault(a => a.Id == id);
        }
        public IList<Album> GetMarketAlbums()
        {
            return Session.Query<Album>().ToList();
        }
        public void GetOwnedAlbums(User user)//IList<Album>
        {
            string requete = "select a from User a";
            var cover = Session.CreateQuery(requete).SetInt32(0, user.Id).List<Cover>();
            return;
        }
        public void GetWishesAlbums(User user)//IList<Album>
        {
            var retour = Session.CreateSQLQuery("SELECT `album_id` FROM `user_album` WHERE `user_id`=1 AND `user_own`=1;");
            
        }
    }
}
