using EntityLayer.Concrate;

namespace BusinessLayer.Services
{
    public interface IDestinationService
    {
        void Add(Destination destination);
        void Delete(Destination destination);
        void Update(Destination destination);
        List<Destination> GetList();
        Destination GetById(int id);
    }
}
