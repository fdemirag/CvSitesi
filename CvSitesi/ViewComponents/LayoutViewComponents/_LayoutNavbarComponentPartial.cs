using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() { return View(); }
	}
}
