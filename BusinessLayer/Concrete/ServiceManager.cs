using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDAL _serviceDAL;

        public ServiceManager(IServiceDAL serviceDAL)
        {
            _serviceDAL = serviceDAL;
        }
        





        public void Add(Service entity)
        {
            _serviceDAL.Add(entity);
        }

        public void Delete(Service entity)
        {
            _serviceDAL.Delete(entity);
        }

        public List<Service> GetAll()
        {
            return _serviceDAL.GetAll();
        }

        public Service GetByID(int id)
        {
            return _serviceDAL.GetByID(id);
        }

        public void Update(Service entity)
        {
            _serviceDAL.Update(entity);
        }
    }
}