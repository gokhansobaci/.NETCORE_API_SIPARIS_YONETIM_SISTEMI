using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayouComponents
{
	public class _LayoutFooterComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
