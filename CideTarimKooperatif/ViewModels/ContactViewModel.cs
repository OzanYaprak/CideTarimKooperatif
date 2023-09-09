using EntityLayer.Concrete;

namespace CideTarimKooperatif.ViewModels
{
    public class ContactViewModel
    {
        public int ContactID { get; set; }
        public Contact Contact { get; set; }

        public int AddressID { get; set; }
        public Address Address { get; set; }
    }
}
