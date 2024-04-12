using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
