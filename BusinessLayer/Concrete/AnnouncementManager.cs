using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDAL _announcementDAL;

        public AnnouncementManager(IAnnouncementDAL announcementDAL)
        {
            _announcementDAL = announcementDAL;
        }

        public void Add(Announcement entity)
        {
            _announcementDAL.Add(entity);
        }

        public void AnnouncementStatusToFalse(int id)
        {
            _announcementDAL.AnnouncementStatusToFalse(id);
        }

        public void AnnouncementStatusToTrue(int id)
        {
            _announcementDAL.AnnouncementStatusToTrue(id);
        }

        public void Delete(Announcement entity)
        {
            _announcementDAL.Delete(entity);
        }

        public List<Announcement> GetAll()
        {
            return _announcementDAL.GetAll();
        }

        public Announcement GetByID(int id)
        {
            return _announcementDAL.GetByID(id);
        }

        public void Update(Announcement entity)
        {
            _announcementDAL.Update(entity);
        }
    }
}