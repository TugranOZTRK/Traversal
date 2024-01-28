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
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;
        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }
        public void Add(Guide guide)
        {
           _guideDal.Insert(guide);
        }

        public void Delete(Guide guide)
        {
           _guideDal.Delete(guide);
        }

        public Guide GetById(int id)
        {
            return _guideDal.GetById(id);
        }

        public List<Guide> GetList()
        {
            return _guideDal.GetListAll();
        }

        public void Update(Guide guide)
        {
            _guideDal.Update(guide);
        }
    }
}
