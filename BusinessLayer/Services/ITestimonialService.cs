using EntityLayer.Concrate;

namespace BusinessLayer.Services
{
    public interface ITestimonialService
    {
        void Add(Testimonial testimonial);
        void Delete(Testimonial testimonial);
        void Update(Testimonial testimonial);
        List<Testimonial> GetList();
        Testimonial GetById(int id);
    }
}
