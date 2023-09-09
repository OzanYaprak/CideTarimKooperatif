using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CideTarimKooperatif.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            ViewBag.MenuIndex = 3;

            var images = _imageService.GetAll();

            if (images.Count == 0)
            {
                ViewBag.Error = "Herhangi bir görsel kaydı bulunmuyor.";
            }

            return View(images);
        }





        [HttpGet]
        public IActionResult AddNewImage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewImage(Image image)
        {
            ImageValidator validationRules = new ImageValidator();
            ValidationResult validationResult = validationRules.Validate(image);

            if (validationResult.IsValid)
            {
                _imageService.Add(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }





        public IActionResult DeleteImage(int id)
        {
            var deletedImage = _imageService.GetByID(id);

            _imageService.Delete(deletedImage);

            return RedirectToAction("Index");
        }





        [HttpGet]
        public IActionResult EditImage(int id)
        {
            var editedImage = _imageService.GetByID(id);

            return View(editedImage);
        }
        [HttpPost]
        public IActionResult EditImage(Image image)
        {
            ImageValidator validationRules = new ImageValidator();
            ValidationResult validationResult = validationRules.Validate(image);

            if (validationResult.IsValid)
            {
                _imageService.Update(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }








    }
}