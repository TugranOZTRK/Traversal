using DataAccessLayer.Abstract;
using EntityLayer.Concrate;

namespace DataAccessLayer.Concrete.EfRepository
{
    public class EfFeatureRepository : Repository<Feature>, IFeatureDal
    {

    }
}
