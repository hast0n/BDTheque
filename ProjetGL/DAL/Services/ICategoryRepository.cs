using Domain;

namespace DAL.Services
{
    public interface ICategoryRepository
    {
        void Save(Category category);
    }
}
