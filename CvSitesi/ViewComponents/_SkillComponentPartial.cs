using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CvSitesi.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
              return View();
        }
    }
}
