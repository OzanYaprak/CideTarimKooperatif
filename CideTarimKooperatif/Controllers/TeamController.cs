using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

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
            _teamService.Add(team);
            return RedirectToAction("Index");
        }
    }
}