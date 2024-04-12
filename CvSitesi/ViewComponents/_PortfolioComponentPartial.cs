using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {
      public  IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
