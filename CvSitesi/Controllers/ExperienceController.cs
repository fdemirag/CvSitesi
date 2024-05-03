using CvSitesi.DataAccess.Context;
using CvSitesi.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
		[HttpGet]
		public IActionResult CreateExperience()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateExperience(Experience experience)
		{
			context.Experiences.Add(experience);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
	}
}
