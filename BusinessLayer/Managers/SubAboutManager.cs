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
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;
        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }
        public void Add(SubAbout subAbout)
        {
           _subAboutDal.Insert(subAbout);
        }

        public void Delete(SubAbout subAbout)
        {
           _subAboutDal.Delete(subAbout);
        }

        public SubAbout GetById(int id)
        {
            return _subAboutDal.GetById(id);
        }

        public List<SubAbout> GetList()
        {
            return _subAboutDal.GetListAll();
        }

        public void Update(SubAbout subAbout)
        {
            _subAboutDal.Update(subAbout);
        }
    }
}
