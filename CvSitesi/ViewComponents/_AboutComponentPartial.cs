using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
