using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayouComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
