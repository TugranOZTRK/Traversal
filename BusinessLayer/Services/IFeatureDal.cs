using EntityLayer.Concrate;

namespace BusinessLayer.Services
{
    public interface IFeatureService
    {
        void Add(Feature feature);
        void Delete(Feature feature);
        void Update(Feature feature);
        List<Feature> GetList();
        Feature GetById(int id);
    }
}
