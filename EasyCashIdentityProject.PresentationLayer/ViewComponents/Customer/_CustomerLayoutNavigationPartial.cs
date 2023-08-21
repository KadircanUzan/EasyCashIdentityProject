using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutNavigationPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           return View();
        }
    }
}
