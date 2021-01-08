using Domain;

namespace DAL.Services
{
    public interface ICoverRepository
    {
        void Save(Cover blobImg);
        Cover GetCoverById(int number);
    }
}
