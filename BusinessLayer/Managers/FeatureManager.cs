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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }
        public void Add(Feature feature)
        {
           _featureDal.Insert(feature);
        }

        public void Delete(Feature feature)
        {
           _featureDal.Delete(feature);
        }

        public Feature GetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public List<Feature> GetList()
        {
            return _featureDal.GetListAll();
        }

        public void Update(Feature feature)
        {
            _featureDal.Update(feature);
        }
    }
}
