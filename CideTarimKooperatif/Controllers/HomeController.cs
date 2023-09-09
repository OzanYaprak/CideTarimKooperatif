using CideTarimKooperatif.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CideTarimKooperatif.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.MenuIndex = 0;

            return View();
        }

    }
}