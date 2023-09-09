using BusinessLayer.Abstract;
using CideTarımKooperatif.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CideTarimKooperatif.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }




        public IActionResult Index()
        {
            ViewBag.MenuIndex = 1;

            var serviceList = _serviceService.GetAll();

            return View(serviceList);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View(new ServiceAddViewModel());
        }
        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _serviceService.Add(new Service()
                {
                    ServiceTitle = viewModel.ServiceTitle,
                    ServiceImage = viewModel.ServiceImage,
                    ServiceDescription = viewModel.ServiceDescription,
                });

                return RedirectToAction("Index");
            }
            else { return View(viewModel); }
        }



        [HttpGet]
        public IActionResult DeleteService(int id)
        {
            var deletedService = _serviceService.GetByID(id);

            if (deletedService != null)
            {
                _serviceService.Delete(deletedService);
                return RedirectToAction("Index");
            }

            return View();
        }



        [HttpGet]
        public IActionResult EditService(int id)
        {
            var updatedService = _serviceService.GetByID(id);

            //if (updatedService != null)
            //{
            //    _serviceService.Update(updatedService);
            //    return RedirectToAction("Index");
            //}

            return View(updatedService);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            if (service != null)
            {
                _serviceService.Update(service);
                return RedirectToAction("Index");
            }
            else { return View(service); }
        }
    }
}
