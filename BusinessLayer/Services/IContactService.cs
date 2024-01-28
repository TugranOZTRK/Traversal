using EntityLayer.Concrate;

namespace BusinessLayer.Services
{
    public interface IContactService
    {
        void Add(Contact contact);
        void Delete(Contact contact);
        void Update(Contact contact);
        List<Contact> GetList();
        Contact GetById(int id);
    }
}
