using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace SignalRWebUI.ViewComponents.LayouComponents
{
	public class _LayoutScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
