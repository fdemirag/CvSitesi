using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
