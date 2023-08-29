using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CideTarimKooperatif.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }



        public IActionResult Index()
        {
            var messages = _contactService.GetAll();

            if (messages.Count == 0)
            {
                ViewBag.Error = "Herhangi bir mesaj kaydı bulunmuyor.";
            }

            return View(messages);
        }




        public IActionResult DeleteMessage(int id)
        {
            var deletedMessage = _contactService.GetByID(id);

            _contactService.Delete(deletedMessage);

            return RedirectToAction("Index");
        }



        public IActionResult MessageDetails(int id)
        {
            var message = _contactService.GetByID(id);

            return View(message);
        }

    }
}
