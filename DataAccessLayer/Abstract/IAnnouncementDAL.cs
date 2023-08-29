using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IAnnouncementDAL : IGenericDAL<Announcement>
    {
        void AnnouncementStatusToTrue(int id);
        void AnnouncementStatusToFalse(int id);
    }
}