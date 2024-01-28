using EntityLayer.Concrate;

namespace BusinessLayer.Services
{
    public interface IAboutService
    {
        void Add(About about);
        void Delete(About about);
        void Update(About about);
        List<About> GetList();
        About GetById(int id);
    }
}
