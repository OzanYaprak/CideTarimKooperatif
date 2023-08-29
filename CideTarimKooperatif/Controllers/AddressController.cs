using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CideTarimKooperatif.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }





        public IActionResult Index()
        {
            var addressList = _addressService.GetAll();
            if (addressList.Count == 0)
            {
                ViewBag.Error = "Herhangi bir adres kaydı bulunmuyor.";
            }
            return View(addressList);
        }






        [HttpGet]
        public IActionResult AddNewAddress()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewAddress(Address address)
        {
            _addressService.Add(address);
            return RedirectToAction("Index");
        }





        public IActionResult DeleteAddress(int id)
        {
            var deletedAddress = _addressService.GetByID(id);

            _addressService.Delete(deletedAddress);

            return RedirectToAction("Index");
        }





        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var editedAddress = _addressService.GetByID(id);

            return View(editedAddress);
        }
        [HttpPost]
        public IActionResult EditAddress(Address address)
        {
            _addressService.Update(address);
            return RedirectToAction("Index");
        }
    }
}