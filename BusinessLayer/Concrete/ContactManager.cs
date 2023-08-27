using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDAL _contactDAL;

        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }




        public void Add(Contact entity)
        {
            _contactDAL.Add(entity);
        }

        public void Delete(Contact entity)
        {
            _contactDAL.Delete(entity);
        }

        public List<Contact> GetAll()
        {
            return _contactDAL.GetAll();
        }

        public Contact GetByID(int id)
        {
            return _contactDAL.GetByID(id);
        }

        public void Update(Contact entity)
        {
            _contactDAL.Update(entity);
        }
    }
}
