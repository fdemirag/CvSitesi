using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
