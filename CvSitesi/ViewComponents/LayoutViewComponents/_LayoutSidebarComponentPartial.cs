using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() { return View(); }
	}
}
