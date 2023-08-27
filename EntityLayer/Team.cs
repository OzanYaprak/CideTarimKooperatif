using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Team
    {
        [Key]
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public string PersonTitle { get; set; }
        public string PersonImageURL { get; set; }
        public string PersonFacebookURL { get; set; }
        public string PersonInstagramURL { get; set; }
        public string PersonTwitterURL { get; set; }
        public string PersonWebsiteURL { get; set; }
    }
}
