using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
            var images = _imageService.GetAll();

            if (images.Count == 0)
            {
                ViewBag.Error = "Herhangi bir görsel kaydı bulunmuyor.";
            }

            return View(images);
        }
    }
}
