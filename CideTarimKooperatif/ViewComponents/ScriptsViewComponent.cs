using Microsoft.AspNetCore.Mvc;

namespace CideTarimKooperatif.ViewComponents
{
    public class ScriptsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
