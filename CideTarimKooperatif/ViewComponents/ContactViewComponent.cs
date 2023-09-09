using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CideTarimKooperatif.ViewComponents
{
    public class ContactViewComponent : ViewComponent
    {
        private readonly IContactService _contactService;

        public ContactViewComponent(IContactService contactService)
        {
            _contactService = contactService;
        }


        public IViewComponentResult Invoke() 
        {
            var values = _contactService.GetAll();

            return View(values); 
        }
    }
}