using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CideTarimKooperatif.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }




        public IActionResult Index()
        {
            var announcements = _announcementService.GetAll();

            if (announcements.Count == 0)
            {
                ViewBag.Error = "Herhangi bir duyuru kaydı bulunmuyor.";
            }

            return View(announcements);
        }



        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(Announcement announcement)
        {
            AnnouncementValidator validationRules = new AnnouncementValidator();
            ValidationResult validationResult = validationRules.Validate(announcement);

            //announcement.EntryDate = DateTime.Parse(DateTime.Now.ToShortDateString());  <----- BU KISIM BİR ALT SATIRINDA YAZILAN KOD SATIRI YERİNE KULLANILABİLİNİR FAKAT BURAYI KULLANIRSAK INDEX İÇİNDEKİ <td>@item.EntryDate.Date.ToShortDateString()</td> SATIRINI <td>@item.EntryDate</td> OLARAK DÜZENLEMEK GEREKİR.
            announcement.EntryDate = DateTime.Now;
            announcement.AnnouncementStatus = false;



            //if(validationResult.IsValid)
            //veya yerine aşağıdaki gibi de yazılabilinir
            if (validationResult != null)
            {
                _announcementService.Add(announcement);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.ErrorCode, item.ErrorMessage);
                }
            }
            return View();
        }



        public IActionResult DeleteAnnouncement(int id)
        {
            var deletedAnnouncement = _announcementService.GetByID(id);

            _announcementService.Delete(deletedAnnouncement);

            return RedirectToAction("Index");
        }




        [HttpGet]
        public IActionResult EditAnnouncement(int id)
        {
            var editedAnnouncement = _announcementService.GetByID(id);

            return View(editedAnnouncement);
        }
        [HttpPost]
        public IActionResult EditAnnouncement(Announcement announcement)
        {
            AnnouncementValidator validationRules = new AnnouncementValidator();
            ValidationResult validationResult = validationRules.Validate(announcement);

            //if(validationResult.IsValid)
            //veya yerine aşağıdaki gibi de yazılabilinir
            if (validationResult != null)
            {
                _announcementService.Update(announcement);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.ErrorCode, item.ErrorMessage);
                }
            }
            return View();
        }































    }
}
