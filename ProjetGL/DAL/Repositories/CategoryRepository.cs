using System.Collections.Generic;
using System.Linq;
using DAL.Services;
using Domain;

namespace DAL.Repositories
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
