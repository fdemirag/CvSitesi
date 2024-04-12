using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }

    }
}
