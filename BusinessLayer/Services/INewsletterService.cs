using EntityLayer.Concrate;

namespace BusinessLayer.Services
{
    public interface INewsletterService
    {
        void Add(Newsletter newsletter);
        void Delete(Newsletter newsletter);
        void Update(Newsletter newsletter);
        List<Newsletter> GetList();
        Newsletter GetById(int id);
    }
}
