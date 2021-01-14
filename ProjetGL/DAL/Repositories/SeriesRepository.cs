using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Services;
using Domain;

namespace DAL.Repositories
{
    public class SeriesRepository:Repository, ISeriesRepository
    {
        public List<Series> GetAll()
        {
            return Session.Query<Series>().ToList();
        }

        public void Save(Series series)
        {
            Session.SaveOrUpdate(series);
            Session.Flush();
        }
    }
}
