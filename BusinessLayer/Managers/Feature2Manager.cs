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
    public class Feature2Manager : IFeature2Service
    {
        IFeature2Dal _feature2Dal;
        public Feature2Manager(IFeature2Dal feature2Dal)
        {
            _feature2Dal = feature2Dal;
        }
        public void Add(Feature2 feature2)
        {
           _feature2Dal.Insert(feature2);
        }

        public void Delete(Feature2 feature2)
        {
           _feature2Dal.Delete(feature2);
        }

        public Feature2 GetById(int id)
        {
            return _feature2Dal.GetById(id);
        }

        public List<Feature2> GetList()
        {
            return _feature2Dal.GetListAll();
        }

        public void Update(Feature2 feature2)
        {
            _feature2Dal.Update(feature2);
        }
    }
}
