using Microsoft.AspNetCore.Mvc;

namespace CideTarimKooperatif.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
