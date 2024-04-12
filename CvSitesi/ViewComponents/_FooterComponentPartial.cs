using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
