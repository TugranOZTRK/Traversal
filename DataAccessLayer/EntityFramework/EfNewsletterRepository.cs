using DataAccessLayer.Abstract;
using EntityLayer.Concrate;

namespace DataAccessLayer.Concrete.EfRepository
{
    public class EfNewsletterRepository : Repository<Newsletter>, INewsletterDal
    {

    }
}
