using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
