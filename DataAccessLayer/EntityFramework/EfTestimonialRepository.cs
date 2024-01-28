using DataAccessLayer.Abstract;
using EntityLayer.Concrate;

namespace DataAccessLayer.Concrete.EfRepository
{
    public class EfTestimonialRepository : Repository<Testimonial>, ITestimonialDal
    {

    }
}
