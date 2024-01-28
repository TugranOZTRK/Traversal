using DataAccessLayer.Abstract;
using EntityLayer.Concrate;

namespace DataAccessLayer.Concrete.EfRepository
{
    public class EfAboutRepository : Repository<About>, IAboutDal
    {

    }
}
