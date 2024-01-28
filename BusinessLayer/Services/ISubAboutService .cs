using EntityLayer.Concrate;

namespace BusinessLayer.Services
{
    public interface ISubAboutService
    {
        void Add(SubAbout subAbout);
        void Delete(SubAbout subAbout);
        void Update(SubAbout subAbout);
        List<SubAbout> GetList();
        SubAbout GetById(int id);
    }
}
