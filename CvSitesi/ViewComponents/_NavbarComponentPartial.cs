using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.VievComponents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() {
            return View();
        }
    }
}
