using EntityLayer.Concrate;

namespace BusinessLayer.Services
{
    public interface IGuideService
    {
        void Add(Guide guide);
        void Delete(Guide guide);
        void Update(Guide guide);
        List<Guide> GetList();
        Guide GetById(int id);
    }
}
