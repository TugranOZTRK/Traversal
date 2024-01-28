using DataAccessLayer.Abstract;
using EntityLayer.Concrate;

namespace DataAccessLayer.Concrete.EfRepository
{
    public class EfContactRepository : Repository<Contact>, IContactDal
    {

    }
}
