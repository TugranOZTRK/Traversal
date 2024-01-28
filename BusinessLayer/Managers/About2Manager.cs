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
    public class About2Manager : IAbout2Service
    {
        IAbout2Dal _aboutDal;
        public About2Manager(IAbout2Dal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void Add(About2 about)
        {
           _aboutDal.Insert(about);
        }

        public void Delete(About2 about)
        {
           _aboutDal.Delete(about);
        }

        public About2 GetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About2> GetList()
        {
            return _aboutDal.GetListAll();
        }

        public void Update(About2 about)
        {
            _aboutDal.Update(about);
        }
    }
}
