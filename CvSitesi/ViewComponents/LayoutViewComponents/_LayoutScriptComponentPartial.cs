using Microsoft.AspNetCore.Mvc;

namespace CvSitesi.ViewComponents.LayoutViewComponents
{
	public class _LayoutScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() { return View(); }
	}
}
