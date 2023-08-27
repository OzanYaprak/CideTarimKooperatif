using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        public string AddressDescFirst { get; set; }
        public string AddressDescSecond { get; set; }
        public string AddressDescThird { get; set; }
        public string AddressDescFour { get; set; }
        public string GoogleMapsURL { get; set; }
    }
}