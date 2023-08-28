using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CideTarimKooperatif.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }



        public IActionResult Index()
        {
            var teamList = _teamService.GetAll();
            if (teamList.Count == 0)
            {
                ViewBag.Error = "Herhangi bir personel kaydı bulunmuyor.";
            }
            return View(teamList);
        }

        [HttpGet]
        public IActionResult AddNewTeamMember()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewTeamMember(Team team)
        {
            TeamValidator teamValidator = new TeamValidator();
            ValidationResult validationResult = teamValidator.Validate(team);

            if (validationResult.IsValid)
            {
                _teamService.Add(team);
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