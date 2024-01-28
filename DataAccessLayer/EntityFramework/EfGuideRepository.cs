using DataAccessLayer.Abstract;
using EntityLayer.Concrate;

namespace DataAccessLayer.Concrete.EfRepository
{
    public class EfGuideRepository : Repository<Guide>, IGuideDal
    {

    }
}
