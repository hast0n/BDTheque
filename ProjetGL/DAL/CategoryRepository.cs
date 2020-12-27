using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    class CategoryRepository : Repository, ICategoryRepository
    {
        public List<Category> GetAll()
        {
            return Session.Query<Category>().ToList();
        }

        public void Save(Category category)
        {
            Session.SaveOrUpdate(category);
            Session.Flush();
        }
    }
}
