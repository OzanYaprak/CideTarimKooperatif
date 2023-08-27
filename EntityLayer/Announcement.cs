using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Announcement
    {
        [Key]
        public int AnnouncementID { get; set; }

        public string AnnouncementTitle { get; set; }
        public string AnnouncementDescription { get; set; }
        public DateTime EntryDate { get; set; }
        public bool AnnouncementStatus { get; set; }
    }
}