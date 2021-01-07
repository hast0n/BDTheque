using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Services;
using Domain;

namespace DAL.Repositories
{
    public class CoverRepository : Repository, ICoverRepository
    {
        public List<Cover> GetAll()
        {
            return Session.Query<Cover>().ToList();
        }
        public Cover GetCover(int number)
        {
            string requete = "select c from Cover c where c.Id=?";
            var cover = Session.CreateQuery(requete).SetInt32(0, number).List<Cover>();
            return cover[0];
        }
        public void Save(Cover blobImg)
        {
            Session.SaveOrUpdate(blobImg);
            Session.Flush();
        }
        public void AddCover(Cover cover)
        {
            throw new NotImplementedException();
        }
    }
}
