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
    public class NewsletterManager : INewsletterService
    {
        INewsletterDal _newsletterDal;
        public NewsletterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }
        public void Add(Newsletter newsletter)
        {
           _newsletterDal.Insert(newsletter);
        }

        public void Delete(Newsletter newsletter)
        {
           _newsletterDal.Delete(newsletter);
        }

        public Newsletter GetById(int id)
        {
            return _newsletterDal.GetById(id);
        }

        public List<Newsletter> GetList()
        {
            return _newsletterDal.GetListAll();
        }

        public void Update(Newsletter newsletter)
        {
            _newsletterDal.Update(newsletter);
        }
    }
}
