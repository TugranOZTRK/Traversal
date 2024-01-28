using BusinessLayer.Services;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Managers
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;
        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }
        public void Add(Testimonial testimonial)
        {
           _testimonialDal.Insert(testimonial);
        }

        public void Delete(Testimonial testimonial)
        {
           _testimonialDal.Delete(testimonial);
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public List<Testimonial> GetList()
        {
            return _testimonialDal.GetListAll();
        }

        public void Update(Testimonial testimonial)
        {
            _testimonialDal.Update(testimonial);
        }
    }
}
