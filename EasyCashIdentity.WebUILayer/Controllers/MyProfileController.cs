using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentity.WebUILayer.Controllers
{
    public class MyProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}