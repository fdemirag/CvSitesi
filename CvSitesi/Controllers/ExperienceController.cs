using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperienceList()
        {
            return View();
        }
    }
}
