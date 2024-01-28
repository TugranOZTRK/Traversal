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
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;
        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }
        public void Add(Destination destination)
        {
           _destinationDal.Insert(destination);
        }

        public void Delete(Destination destination)
        {
           _destinationDal.Delete(destination);
        }

        public Destination GetById(int id)
        {
            return _destinationDal.GetById(id);
        }

        public List<Destination> GetList()
        {
            return _destinationDal.GetListAll();
        }

        public void Update(Destination destination)
        {
            _destinationDal.Update(destination);
        }
    }
}
