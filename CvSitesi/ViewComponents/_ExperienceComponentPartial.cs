using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
