using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() { return View(); }
	}
}
