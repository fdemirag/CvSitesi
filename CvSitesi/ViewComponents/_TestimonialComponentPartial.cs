using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.ViewComponents
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
