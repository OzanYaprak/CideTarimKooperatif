using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDAL _socialMediaDAL;

        public SocialMediaManager(ISocialMediaDAL socialMediaDAL)
        {
            _socialMediaDAL = socialMediaDAL;
        }



        public void Add(SocialMedia entity)
        {
            _socialMediaDAL.Add(entity);
        }

        public void Delete(SocialMedia entity)
        {
           _socialMediaDAL.Delete(entity);
        }

        public List<SocialMedia> GetAll()
        {
            return _socialMediaDAL.GetAll();
        }

        public SocialMedia GetByID(int id)
        {
            return _socialMediaDAL.GetByID(id);
        }

        public void Update(SocialMedia entity)
        {
            _socialMediaDAL.Update(entity);
        }
    }
}
