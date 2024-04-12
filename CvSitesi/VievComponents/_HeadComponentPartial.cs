using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.VievComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();        
        }
    }
}
