using EntityLayer.Concrate;

namespace BusinessLayer.Services
{
    public interface IAbout2Service
    {
        void Add(About2 about);
        void Delete(About2 about);
        void Update(About2 about);
        List<About2> GetList();
        About2 GetById(int id);
    }
}
