using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Contexts;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EFAnnouncementDAL : GenericRepository<Announcement>, IAnnouncementDAL
    {
        private CideTarımDB CideTarımDB = new CideTarımDB();


        public void AnnouncementStatusToFalse(int id)
        {
            Announcement announcementToUpdate = CideTarımDB.Announcements.Find(id);
            announcementToUpdate.AnnouncementStatus = false;

            CideTarımDB.SaveChanges();
        }

        public void AnnouncementStatusToTrue(int id)
        {
            Announcement announcementToUpdate = CideTarımDB.Announcements.Find(id);
            announcementToUpdate.AnnouncementStatus = true;

            CideTarımDB.SaveChanges();
        }
    }
}