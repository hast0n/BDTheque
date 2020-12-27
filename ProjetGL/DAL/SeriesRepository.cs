using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    class SeriesRepository:Repository, ISeriesRepository
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
