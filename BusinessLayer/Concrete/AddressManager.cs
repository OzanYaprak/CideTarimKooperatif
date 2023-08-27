using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDAL _addressDAL;

        public AddressManager(IAddressDAL addressDAL)
        {
            _addressDAL = addressDAL;
        }

        public void Add(Address entity)
        {
            _addressDAL.Add(entity);
        }

        public void Delete(Address entity)
        {
            _addressDAL.Delete(entity);
        }

        public List<Address> GetAll()
        {
            return _addressDAL.GetAll();
        }

        public Address GetByID(int id)
        {
            return _addressDAL.GetByID(id);
        }

        public void Update(Address entity)
        {
            _addressDAL.Update(entity);
        }
    }
}