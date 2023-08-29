using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Image
    {
        [Key]
        public int ImageID { get; set; }
        public string ImageTitle { get; set; }
        public string ImageDescription { get; set; }
        public string ImageURl { get; set; }
    }
}
