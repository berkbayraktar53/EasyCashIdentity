using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentity.WebUILayer.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}