using EntityLayer.Concrate;

namespace BusinessLayer.Services
{
    public interface IFeature2Service
    {
        void Add(Feature2 feature);
        void Delete(Feature2 feature);
        void Update(Feature2 feature);
        List<Feature2> GetList();
        Feature2 GetById(int id);
    }
}
