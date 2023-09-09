using Microsoft.AspNetCore.Mvc;

namespace CideTarimKooperatif.ViewComponents
{
    public class HeadViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
